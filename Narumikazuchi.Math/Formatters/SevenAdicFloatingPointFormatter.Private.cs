namespace Narumikazuchi.Math.Formatters;

public partial class SevenAdicFloatingPointFormatter
{
    static private String FormatToSpanInternal(Double floatingPoint,
                                               UInt16 precision)
    {
        if (floatingPoint is 0d)
        {
            return "0";
        }

        StringBuilder builder = new();
        Double integerPart = System.Math.Floor(System.Math.Abs(floatingPoint));
        Double fractionPart = System.Math.Abs(floatingPoint) - integerPart;
        while (integerPart > 0d)
        {
            Double quotient = System.Math.Floor(integerPart / 7d);
            Double remainder = integerPart % 7d;
            builder.Insert(index: 0,
                           value: remainder switch
                           {
                               0d => '0',
                               1d => '1',
                               2d => '2',
                               3d => '3',
                               4d => '4',
                               5d => '5',
                               6d => '6',
                               _ => throw new FormatException()
                           });

            integerPart = quotient;
        }

        if (builder.Length is 0)
        {
            builder.Append('0');
        }

        if (precision > 0)
        {
            if (fractionPart > 0d)
            {
                builder.Append('.');
            }

            UInt16 decimalPlaces = 0;
            while (fractionPart > 0d &&
                   decimalPlaces < precision)
            {
                fractionPart *= 7d;
                Double digit = System.Math.Floor(fractionPart);
                builder.Append(digit switch
                {
                    0d => '0',
                    1d => '1',
                    2d => '2',
                    3d => '3',
                    4d => '4',
                    5d => '5',
                    6d => '6',
                    _ => throw new FormatException()
                });

                fractionPart -= digit;
                decimalPlaces++;
            }
        }

        if (floatingPoint < 0)
        {
            builder.Insert(index: 0,
                           value: '-');
        }

        return builder.ToString();
    }
}