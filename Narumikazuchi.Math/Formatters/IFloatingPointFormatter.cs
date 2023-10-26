namespace Narumikazuchi.Math.Formatters;

/// <summary>
/// Provides the functionality to format a floating point number of type <typeparamref name="TFloatingPoint"/> into a specific visual representation.
/// </summary>
public interface IFloatingPointFormatter<TFloatingPoint>
#if NET7_0_OR_GREATER
    where TFloatingPoint : IBinaryFloatingPointIeee754<TFloatingPoint>
#else
    where TFloatingPoint : unmanaged, IComparable, IComparable<TFloatingPoint>, IEquatable<TFloatingPoint>, IFormattable, ISpanFormattable
#endif
{
    /// <summary>
    /// Format the given <paramref name="floatingPoint"/> into a <see cref="ReadOnlySpan{Char}"/> of type <see cref="Char"/>.
    /// </summary>
    /// <param name="floatingPoint">The value to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>A <see cref="ReadOnlySpan{Char}"/> of type <see cref="Char"/> representing the value of <paramref name="floatingPoint"/>.</returns>
    public ReadOnlySpan<Char> FormatToSpan(TFloatingPoint floatingPoint,
                                           UInt16 precision = 3);

    /// <summary>
    /// Format the given <paramref name="floatingPoint"/> into a <see cref="String"/>.
    /// </summary>
    /// <param name="floatingPoint">The value to format.</param>
    /// <param name="precision">The number of decimal places.</param>
    /// <returns>A <see cref="String"/> representing the value of <paramref name="floatingPoint"/>.</returns>
    public String FormatToString(TFloatingPoint floatingPoint,
                                 UInt16 precision = 3);
}