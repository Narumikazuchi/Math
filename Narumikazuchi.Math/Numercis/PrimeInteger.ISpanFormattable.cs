namespace Narumikazuchi.Math.Numerics;

public partial struct PrimeInteger : ISpanFormattable
{
    /// <inheritdoc/>
    public Boolean TryFormat(Span<Char> destination,
                             out Int32 charsWritten,
                             ReadOnlySpan<Char> format,
                             IFormatProvider? provider)
    {
        return this.Value.TryFormat(destination: destination,
                                    charsWritten: out charsWritten,
                                    format: format,
                                    provider: provider);
    }
}