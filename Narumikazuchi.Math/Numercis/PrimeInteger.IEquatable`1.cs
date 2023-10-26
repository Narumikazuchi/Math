namespace Narumikazuchi.Math.Numerics;

public partial struct PrimeInteger : IEquatable<UInt32>
{
    /// <inheritdoc/>
    public Boolean Equals(UInt32 other)
    {
        return this.Value.Equals(other);
    }
}

public partial struct PrimeInteger : IEquatable<PrimeInteger>
{
    /// <inheritdoc/>
    public Boolean Equals(PrimeInteger other)
    {
        return this.Value.Equals(other.Value);
    }
}