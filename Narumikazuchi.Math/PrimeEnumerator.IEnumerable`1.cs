using Narumikazuchi.Math.Numerics;

namespace Narumikazuchi.Math;

public partial struct PrimeEnumerator : IEnumerable<PrimeInteger>
{
    readonly IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    readonly IEnumerator<PrimeInteger> IEnumerable<PrimeInteger>.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}