namespace Narumikazuchi.Math;

public partial class PrimeGenerator
{
    static private Int32 ApproachInRange(Int64 value,
                                         Range range,
                                         Boolean reverse)
    {
        Int32 length = range.End.Value - range.Start.Value;
        if (length == 1)
        {
            if (reverse)
            {
                return range.Start.Value;
            }
            return range.End.Value;
        }

        length = (length + 1) / 2;
        if (value > s_Primes[range.Start] &&
            value <= s_Primes[range.Start.Value + length])
        {
            return ApproachInRange(value: value,
                                   range: range.Start.Value..(range.Start.Value + length),
                                   reverse: reverse);
        }

        if (value > s_Primes[range.Start.Value + length] &&
            value <= s_Primes[range.End])
        {
            return ApproachInRange(value: value,
                                   range: (range.Start.Value + length)..range.End,
                                   reverse: reverse);
        }

        if (reverse)
        {
            return range.End.Value;
        }

        return range.Start.Value;
    }

    [MethodImpl(MethodImplOptions.AggressiveOptimization)]
#if NET7_0_OR_GREATER
    static private unsafe void RunSieve(UInt32 size)
    {
        UInt32 factor = 3;
        UInt32 halfFactor = factor >> 1;
        UInt32 halfRoot = ((UInt32)(System.Math.Sqrt(size) + 1)) >> 1;

        UInt32 halfLimit = (size + 1) / 2;
        UInt64[] bits = new UInt64[(Int32)(halfLimit / WORD_BITS + 1)];

        fixed (UInt64* pointer = bits)
        {
            while (true)
            {
                UInt64 segment = pointer[halfFactor / 64];
                UInt32 offset = halfFactor % 64;
                segment = ~segment;
                segment >>= (Int32)offset;
                Int32 jump = BitOperations.TrailingZeroCount(segment);
                if (jump is 64)
                {
                    halfFactor += 64 - offset;
                    continue;
                }

                halfFactor += (UInt32)jump;
                factor = (halfFactor << 1) + 1;
                halfFactor++;

                if (halfFactor > halfRoot)
                {
                    break;
                }

                ClearBitsStride8BlocksUnrolled(ptr: (Byte*)pointer,
                                               start: factor * factor / 2,
                                               factor: factor,
                                               limit: halfLimit);
            }
        }

        ImmutableArray<UInt32>.Builder builder = ImmutableArray.CreateBuilder<UInt32>((Int32)(size / 8));
        builder.Add(2);
        for (UInt32 candidate = 3;
             candidate <= size;
             candidate += 2)
        {
            if ((bits[candidate / 2 / 64] & (1UL << (Int32)(candidate / 2))) == 0)
            {
                builder.Add(candidate);
            }
        }

        s_Primes = builder.ToImmutable();
        s_LastSieveSize = size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static private unsafe void ClearBitsStride8BlocksUnrolled(Byte* ptr,
                                                              UInt32 start,
                                                              UInt32 factor,
                                                              UInt32 limit)
    {
        Span<(UInt32, Byte)> strides = stackalloc (UInt32, Byte)[8];
        for (UInt32 index = 0;
             index < 8;
             index++)
        {
            UInt32 s = start + factor * index;
            strides[(Int32)index] = (s / 8, (Byte)(1 << ((Int32)s % 8)));
        }

        UInt32 bytecount = limit / 8;
        UInt32 blockStart = start / 8;

        while (blockStart <= bytecount)
        {
            for (Int32 stride = 0;
                 stride < 8;
                 stride++)
            {
                (UInt32 index, Byte mask) = strides[stride];
                UInt32 blockEnd = System.Math.Min(bytecount + 1, index + BLOCKSIZE);
                Byte* blockEndPtr = ptr + blockEnd;

                Byte* i0 = ptr + index;
                Byte* i1 = ptr + index + factor;
                Byte* i2 = ptr + index + factor * 2;
                Byte* i3 = ptr + index + factor * 3;

                UInt32 factor4 = factor * 4;
                for (; i3 < blockEndPtr;)
                {
                    i0[0] |= mask;
                    i1[0] |= mask;
                    i2[0] |= mask;
                    i3[0] |= mask;

                    i0 += factor4;
                    i1 += factor4;
                    i2 += factor4;
                    i3 += factor4;
                }

                for (; i0 < blockEndPtr; i0 += factor)
                {
                    i0[0] |= mask;
                }

                strides[stride] = ((UInt32)(i0 - ptr), mask);
            }

            blockStart += BLOCKSIZE;
        }
    }
#else
    static private void RunSieve(UInt32 size)
    {
        Int32 max = (Int32)System.Math.Sqrt(size);
        // Needed size = size of sieve / size in bytes * 8 * 2
        // 8 = 8 bits per byte, 2 = beginning from 1 we only check every 2nd, that is every odd number after
        // In this way we can save half the memory space
        UInt32[] bits = GC.AllocateUninitializedArray<UInt32>(1 + (Int32)size / (sizeof(UInt32) * 16), pinned: true);
        bits.AsSpan().Fill(UInt32.MaxValue);

        for (UInt32 factor = 3;
             factor <= max;
             factor += 2)
        {
            if (GetBit(factor, bits))
            {
                for (UInt32 multiple = factor * factor;
                     multiple <= size;
                     multiple += factor * 2)
                {
                    ClearBit(multiple, bits);
                }
            }
        }

        ImmutableArray<UInt32>.Builder builder = ImmutableArray.CreateBuilder<UInt32>((Int32)(size / 8));
        builder.Add(2);
        for (UInt32 candidate = 3;
             candidate <= size;
             candidate += 2)
        {
            if (GetBit(candidate, bits))
            {
                builder.Add(candidate);
            }
        }

        s_Primes = builder.ToImmutable();
        s_LastSieveSize = size;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static private Boolean GetBit(UInt32 number,
                                  UInt32[] bits)
    {
        Int32 position = checked((Int32)(number / 2));
        Int32 index = position / (sizeof(UInt32) * 8);
        Int32 bit = position % (sizeof(UInt32) * 8);
        UInt32 mask = INITIALMASK >> bit;
        return (bits[index] & mask) == mask;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static private void ClearBit(UInt32 number,
                                 UInt32[] bits)
    {
        Int32 position = checked((Int32)(number / 2));
        Int32 index = position / (sizeof(UInt32) * 8);
        Int32 bit = position % (sizeof(UInt32) * 8);
        UInt32 mask = INITIALMASK >> bit;
        bits[index] &= ~mask;
    }
#endif

    static private ImmutableArray<UInt32> s_Primes = ImmutableArray<UInt32>.Empty;
    static private UInt32 s_LastSieveSize = 0;

#if NET7_0_OR_GREATER
    private const UInt32 BLOCKSIZE = 0x8000;
    private const Int32 WORD_BITS = sizeof(UInt64) * 8;
#else
    private const UInt32 INITIALMASK = 0b1000_0000_0000_0000_0000_0000_0000_0000;
#endif
}