using Narumikazuchi.Math;
using Narumikazuchi.Math.Numerics;

namespace PrimeCalculation;

[TestClass]
public sealed class The_primes_class
{
    [TestMethod]
    [DataRow(3U)]
    [DataRow(5U)]
    [DataRow(227U)]
    [DataRow(773U)]
    [DataRow(5443U)]
    public void will_return_true_for_isprime_if_parameter_is_prime(UInt32 value)
    {
        Assert.IsTrue(PrimeGenerator.IsPrime(value));
    }

    [TestMethod]
    [DataRow(4U)]
    [DataRow(16U)]
    [DataRow(224U)]
    [DataRow(768U)]
    [DataRow(5822U)]
    public void will_return_false_for_isprime_if_parameter_is_not_prime(UInt32 value)
    {
        Assert.IsFalse(PrimeGenerator.IsPrime(value));
    }

    [TestMethod]
    public void will_return_next_smallest_prime_relative_to_parameter_for_getprevious()
    {
        Assert.AreEqual(5U, (UInt32)PrimeGenerator.NearestSmallerPrime(7));
    }

    [TestMethod]
    public void will_return_next_bigger_prime_relative_to_parameter_for_getnext()
    {
        Assert.AreEqual(709U, (UInt32)PrimeGenerator.NearestBiggerPrime(702));
    }

    [TestMethod]
    public void will_return_primes_is_range_provided_by_parameter_for_listuntil()
    {
        PrimeInteger[] control = new PrimeInteger[]
        {
            new(211, true),
            new(223, true),
            new(227, true),
            new(229, true),
            new(233, true),
            new(239, true),
            new(241, true),
            new(251, true),
            new(257, true),
            new(263, true),
            new(269, true),
            new(271, true),
            new(277, true),
            new(281, true),
            new(283, true),
            new(293, true)
        };
        PrimeInteger[] values = PrimeGenerator.ListUntil(200, 300)
                                              .ToArray();
        Assert.IsTrue(control.SequenceEqual(values), $"Excpected: [{String.Join(',', control.Select(p => p.Value))}] Actual: [{String.Join(',', values.Select(p => p.Value))}]");
    }
}