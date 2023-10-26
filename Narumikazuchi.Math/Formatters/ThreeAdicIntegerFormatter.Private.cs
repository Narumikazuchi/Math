namespace Narumikazuchi.Math.Formatters;

public partial class ThreeAdicIntegerFormatter
{
    static private ReadOnlySpan<Char> FormatToSpan8Bit(Int32 integer,
                                                       Span<Char> builder)
    {
        if (integer is 0)
        {
            builder[0] = '0';
            return builder[..1];
        }

        Int32 value = integer;
        Int32 index = 6;
        while (value > 0)
        {
            Int32 quotient = value / 3;
            Int32 remainder = value % 3;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }

    static private ReadOnlySpan<Char> FormatToSpan16Bit(Int32 integer,
                                                        Span<Char> builder)
    {
        if (integer is 0)
        {
            builder[0] = '0';
            return builder[..1];
        }

        Int32 value = integer;
        Int32 index = 11;
        while (value > 0)
        {
            Int32 quotient = value / 3;
            Int32 remainder = value % 3;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }

    static private ReadOnlySpan<Char> FormatToSpan32Bit(Int64 integer,
                                                        Span<Char> builder)
    {
        if (integer is 0)
        {
            builder[0] = '0';
            return builder[..1];
        }

        Int64 value = integer;
        Int32 index = 21;
        while (value > 0)
        {
            Int64 quotient = value / 3;
            Int64 remainder = value % 3;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }

    static private ReadOnlySpan<Char> FormatToSpan64Bit(UInt64 integer,
                                                        Span<Char> builder)
    {
        if (integer is 0)
        {
            builder[0] = '0';
            return builder[..1];
        }

        UInt64 value = integer;
        Int32 index = 41;
        while (value > 0)
        {
            UInt64 quotient = value / 3;
            UInt64 remainder = value % 3;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }
}