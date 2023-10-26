namespace Narumikazuchi.Math.Formatters;

/// <summary>
/// Provides the functionality to format an integer of type <typeparamref name="TInteger"/> into a specific visual representation.
/// </summary>
public interface IIntegerFormatter<TInteger>
#if NET7_0_OR_GREATER
    where TInteger : IBinaryInteger<TInteger>
#else
    where TInteger : unmanaged, IComparable, IComparable<TInteger>, IEquatable<TInteger>, IFormattable, ISpanFormattable
#endif
{
    /// <summary>
    /// Format the given <paramref name="integer"/> into a <see cref="ReadOnlySpan{Char}"/> of type <see cref="Char"/>.
    /// </summary>
    /// <param name="integer">The value to format.</param>
    /// <returns>A <see cref="ReadOnlySpan{Char}"/> of type <see cref="Char"/> representing the value of <paramref name="integer"/>.</returns>
    public ReadOnlySpan<Char> FormatToSpan(TInteger integer);

    /// <summary>
    /// Format the given <paramref name="integer"/> into a <see cref="String"/>.
    /// </summary>
    /// <param name="integer">The value to format.</param>
    /// <returns>A <see cref="String"/> representing the value of <paramref name="integer"/>.</returns>
    public String FormatToString(TInteger integer);
}