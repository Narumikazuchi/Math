namespace Narumikazuchi.Math.Formatters;

/// <summary>
/// Represents integers in the form of roman numerals.
/// </summary>
public sealed class RomanIntegerFormatter :
    IIntegerFormatter<Byte>,
    IIntegerFormatter<UInt16>
{
    /// <summary>
    /// Gets the default instance of the <see cref="RomanIntegerFormatter"/>.
    /// </summary>
    static public RomanIntegerFormatter Default { get; } = new();

    /// <summary>
    /// Formats the <paramref name="integer"/> into a visual representation using roman numerals.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The number represented as roman numeral.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Byte integer)
    {
        return this.FormatToString(integer);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a visual representation using roman numerals.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The number represented as roman numeral.</returns>
    public ReadOnlySpan<Char> FormatToSpan(UInt16 integer)
    {
        return this.FormatToString(integer);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a visual representation using roman numerals.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The number represented as roman numeral.</returns>
    public String FormatToString(Byte integer)
    {
        if (integer is 0)
        {
            return "NULLA";
        }

        StringBuilder builder = new();

        Byte value = integer;
        ImmutableArray<UInt16>.Enumerator literalKey = s_LiteralKeys.GetEnumerator();
        while (literalKey.MoveNext() &&
               literalKey.Current > Byte.MaxValue)
        { }

        while (value > 0)
        {
            while (value >= literalKey.Current)
            {
                builder.Append(s_Literals[literalKey.Current]);
                value -= (Byte)literalKey.Current;
            }

            literalKey.MoveNext();
        }

        return builder.ToString();
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a visual representation using roman numerals.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The number represented as roman numeral.</returns>
    public String FormatToString(UInt16 integer)
    {
        if (integer is 0)
        {
            return "NULLA";
        }

        StringBuilder builder = new();

        UInt16 value = integer;
        ImmutableArray<UInt16>.Enumerator literalKey = s_LiteralKeys.GetEnumerator();
        while (literalKey.MoveNext() &&
               value > 0)
        {
            while (value >= literalKey.Current)
            {
                builder.Append(s_Literals[literalKey.Current]);
                value -= literalKey.Current;
            }
        }

        return builder.ToString();
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    static private readonly ImmutableArray<UInt16> s_LiteralKeys = new UInt16[]
    {
        1000,
        900, 
        500,
        400,
        100,
        90,
        50,
        40,
        10,
        9,
        5,
        4,
        1
    }.ToImmutableArray();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    static private readonly ImmutableDictionary<UInt16, String> s_Literals = new Dictionary<UInt16, String>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    }.ToImmutableDictionary();
}