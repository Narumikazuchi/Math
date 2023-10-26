using Narumikazuchi.Math.Numerics;

namespace Narumikazuchi.Math;

/// <summary>
/// A helper class that generates prime numbers and checks if a given number is a prime number.
/// </summary>
static public partial class PrimeGenerator
{
    /// <summary>
    /// Checks whether the given <paramref name="candidate"/> is a prime number.
    /// </summary>
    /// <param name="candidate">The number to check.</param>
    /// <returns><see langword="true"/> if the <paramref name="candidate"/> is a prime number; otherwise, <see langword="false"/></returns>
    static public Boolean IsPrime(UInt32 candidate)
    {
        if (candidate > s_LastSieveSize)
        {
            RunSieve(candidate);
        }

        Int32 index = s_Primes.BinarySearch(candidate);
        return index > -1;
    }

    /// <summary>
    /// Gets the closest prime number to <paramref name="origin"/> which is also smaller than <paramref name="origin"/>.
    /// </summary>
    /// <param name="origin">The relative origin for the search.</param>
    /// <returns>The closest prime number to <paramref name="origin"/> which is also smaller than <paramref name="origin"/>.</returns>
    static public PrimeInteger NearestSmallerPrime(UInt32 origin)
    {
        if (origin > s_LastSieveSize)
        {
            RunSieve(origin);
        }

        Int32 index = ApproachInRange(value: origin,
                                      range: 0..(s_Primes.Length - 1),
                                      reverse: true);
        return new(s_Primes[index], true);
    }

    /// <summary>
    /// Gets the closest prime number to <paramref name="origin"/> which is also bigger than <paramref name="origin"/>.
    /// </summary>
    /// <param name="origin">The relative origin for the search.</param>
    /// <returns>The closest prime number to <paramref name="origin"/> which is also smaller than <paramref name="origin"/>.</returns>
    static public PrimeInteger NearestBiggerPrime(UInt32 origin)
    {
        if (origin > s_LastSieveSize)
        {
            // Little safety buffer to ensure the inclusion of the next prime
            RunSieve(origin + 64);
        }

        Int32 index = ApproachInRange(value: origin,
                                      range: 0..(s_Primes.Length - 1),
                                      reverse: false);
        return new(s_Primes[index], true);
    }

    /// <summary>
    /// Enumerates all primes in the range specified by the starting point to the end point.
    /// </summary>
    /// <returns>An ascending list of primes that appear in the specified range</returns>
    static public PrimeEnumerator ListUntil(UInt32 startPoint,
                                            UInt32 endPoint)
    {
        if (startPoint > endPoint)
        {
            (startPoint, endPoint) = (endPoint, startPoint);
        }

        if (endPoint > s_LastSieveSize)
        {
            RunSieve(endPoint);
        }

        return new(values: s_Primes,
                   startPoint: startPoint,
                   endPoint: endPoint);
    }
}