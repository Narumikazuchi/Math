namespace Narumikazuchi.Math.Numerics;

public partial struct PrimeInteger : IComparable<PrimeInteger>
{
    /// <inheritdoc/>
    public Int32 CompareTo(PrimeInteger other)
    {
        return this.Value.CompareTo(other.Value);
    }
}