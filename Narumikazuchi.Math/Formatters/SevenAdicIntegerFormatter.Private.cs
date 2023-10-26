namespace Narumikazuchi.Math.Formatters;

public partial class SevenAdicIntegerFormatter
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
        Int32 index = 3;
        while (value > 0)
        {
            Int32 quotient = value / 7;
            Int32 remainder = value % 7;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
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
        Int32 index = 6;
        while (value > 0)
        {
            Int32 quotient = value / 7;
            Int32 remainder = value % 7;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
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
        Int32 index = 12;
        while (value > 0)
        {
            Int64 quotient = value / 7;
            Int64 remainder = value % 7;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
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
        Int32 index = 23;
        while (value > 0)
        {
            UInt64 quotient = value / 7;
            UInt64 remainder = value % 7;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                5 => '5',
                6 => '6',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }
}