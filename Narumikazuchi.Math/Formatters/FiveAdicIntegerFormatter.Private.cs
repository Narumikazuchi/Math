namespace Narumikazuchi.Math.Formatters;

public partial class FiveAdicIntegerFormatter
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
        Int32 index = 4;
        while (value > 0)
        {
            Int32 quotient = value / 5;
            Int32 remainder = value % 5;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
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
        Int32 index = 7;
        while (value > 0)
        {
            Int32 quotient = value / 5;
            Int32 remainder = value % 5;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
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
        Int32 index = 14;
        while (value > 0)
        {
            Int64 quotient = value / 5;
            Int64 remainder = value % 5;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
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
        Int32 index = 28;
        while (value > 0)
        {
            UInt64 quotient = value / 5;
            UInt64 remainder = value % 5;
            builder[--index] = remainder switch
            {
                0 => '0',
                1 => '1',
                2 => '2',
                3 => '3',
                4 => '4',
                _ => throw new FormatException()
            };
            value = quotient;
        }

        return builder[index..];
    }
}