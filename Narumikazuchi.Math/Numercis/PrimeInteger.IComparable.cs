namespace Narumikazuchi.Math.Numerics;

public partial struct PrimeInteger : IComparable
{
    /// <inheritdoc/>
    readonly Int32 IComparable.CompareTo(Object? obj)
    {
        return this.Value.CompareTo(obj);
    }
}