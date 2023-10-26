namespace Narumikazuchi.Math.Formatters;

/// <summary>
/// Formats any given integer into a base-3 representation.
/// </summary>
public sealed partial class ThreeAdicIntegerFormatter :
    IIntegerFormatter<SByte>,
    IIntegerFormatter<Byte>,
    IIntegerFormatter<Int16>,
    IIntegerFormatter<UInt16>,
    IIntegerFormatter<Int32>,
    IIntegerFormatter<UInt32>,
    IIntegerFormatter<Int64>,
    IIntegerFormatter<UInt64>
{
    /// <summary>
    /// Gets the default instance of the <see cref="ThreeAdicIntegerFormatter"/>.
    /// </summary>
    static public ThreeAdicIntegerFormatter Default { get; } = new();

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(SByte integer)
    {
        Span<Char> builder = stackalloc Char[6];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: -integer,
                                                         builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: integer,
                                                         builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Byte integer)
    {
        Span<Char> builder = stackalloc Char[6];
        ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: integer,
                                                     builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Int16 integer)
    {
        Span<Char> builder = stackalloc Char[11];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: -integer,
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(UInt16 integer)
    {
        Span<Char> builder = stackalloc Char[11];
        ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Int32 integer)
    {
        Span<Char> builder = stackalloc Char[21];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: -(Int64)integer,
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(UInt32 integer)
    {
        Span<Char> builder = stackalloc Char[21];
        ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Int64 integer)
    {
        Span<Char> builder = stackalloc Char[41];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: (UInt64)(-integer),
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: (UInt64)integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(UInt64 integer)
    {
        Span<Char> builder = stackalloc Char[41];
        ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(SByte integer)
    {
        Span<Char> builder = stackalloc Char[6];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: -integer,
                                                         builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: integer,
                                                         builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(Byte integer)
    {
        Span<Char> builder = stackalloc Char[6];
        ReadOnlySpan<Char> result = FormatToSpan8Bit(integer: integer,
                                                     builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(Int16 integer)
    {
        Span<Char> builder = stackalloc Char[11];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: -integer,
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(UInt16 integer)
    {
        Span<Char> builder = stackalloc Char[11];
        ReadOnlySpan<Char> result = FormatToSpan16Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(Int32 integer)
    {
        Span<Char> builder = stackalloc Char[21];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: -(Int64)integer,
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(UInt32 integer)
    {
        Span<Char> builder = stackalloc Char[21];
        ReadOnlySpan<Char> result = FormatToSpan32Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(Int64 integer)
    {
        Span<Char> builder = stackalloc Char[41];

        if (integer < 0)
        {
            ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: (UInt64)(-integer),
                                                          builder: builder);
            builder = stackalloc Char[result.Length + 1];
            result.CopyTo(builder[1..]);
            builder[0] = '-';
            return new String(builder);
        }
        else
        {
            ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: (UInt64)integer,
                                                          builder: builder);
            return new String(result);
        }
    }

    /// <summary>
    /// Formats the <paramref name="integer"/> into a base-3 representation.
    /// </summary>
    /// <param name="integer">The number to format.</param>
    /// <returns>The <paramref name="integer"/> in base-3 representation.</returns>
    public String FormatToString(UInt64 integer)
    {
        Span<Char> builder = stackalloc Char[41];
        ReadOnlySpan<Char> result = FormatToSpan64Bit(integer: integer,
                                                      builder: builder);

        return new String(result);
    }
}