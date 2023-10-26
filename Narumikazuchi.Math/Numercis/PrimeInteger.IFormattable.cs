namespace Narumikazuchi.Math.Numerics;

public partial struct PrimeInteger : IFormattable
{
    /// <inheritdoc/>
    public String ToString(String? format,
                           IFormatProvider? formatProvider)
    {
        return this.Value.ToString(format: format,
                                   provider: formatProvider);
    }
}