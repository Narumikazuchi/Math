﻿namespace Narumikazuchi.Math.Formatters;

/// <summary>
/// Formats any given number into a base-7 representation.
/// </summary>
public sealed partial class SevenAdicFloatingPointFormatter :
    IFloatingPointFormatter<Half>,
    IFloatingPointFormatter<Single>,
    IFloatingPointFormatter<Double>
{
    /// <summary>
    /// Gets the default instance of the <see cref="SevenAdicFloatingPointFormatter"/>.
    /// </summary>
    static public SevenAdicFloatingPointFormatter Default { get; } = new();

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Half floatingPoint,
                                           UInt16 precision)
    {
        return FormatToSpanInternal(floatingPoint: (Double)floatingPoint,
                                    precision: precision);
    }

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Single floatingPoint,
                                           UInt16 precision)
    {
        return FormatToSpanInternal(floatingPoint: floatingPoint,
                                    precision: precision);
    }

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public ReadOnlySpan<Char> FormatToSpan(Double floatingPoint,
                                           UInt16 precision)
    {
        return FormatToSpanInternal(floatingPoint: floatingPoint,
                                    precision: precision);
    }

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public String FormatToString(Half floatingPoint,
                                 UInt16 precision = 3)
    {
        return FormatToSpanInternal(floatingPoint: (Double)floatingPoint,
                                    precision: precision);
    }

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public String FormatToString(Single floatingPoint,
                                 UInt16 precision = 3)
    {
        return FormatToSpanInternal(floatingPoint: floatingPoint,
                                    precision: precision);
    }

    /// <summary>
    /// Formats the <paramref name="floatingPoint"/> into a base-7 representation with <paramref name="precision"/> as number of decimal places.
    /// </summary>
    /// <param name="floatingPoint">The number to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>The <paramref name="floatingPoint"/> in base-7 representation.</returns>
    public String FormatToString(Double floatingPoint,
                                 UInt16 precision = 3)
    {
        return FormatToSpanInternal(floatingPoint: floatingPoint,
                                    precision: precision);
    }
}