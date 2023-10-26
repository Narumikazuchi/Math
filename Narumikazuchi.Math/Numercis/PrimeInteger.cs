namespace Narumikazuchi.Math.Numerics;

/// <summary>
/// Represents a prime number.
/// </summary>
public readonly partial struct PrimeInteger
{
    /// <summary>
    /// Implicit conversion to <see cref="UInt32"/> struct.
    /// </summary>
    static public implicit operator UInt32(PrimeInteger source)
    {
        return source.Value;
    }

    /// <summary>
    /// Implicit conversion from <see cref="UInt32"/> struct.
    /// </summary>
    static public implicit operator PrimeInteger(UInt32 source)
    {
        if (source < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(source));
        }

        return new(source);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PrimeInteger"/> struct.
    /// </summary>
    /// <param name="source">The value of the prime.</param>
    /// <param name="alreadyChecked">Whether or not to check if the <paramref name="source"/> is actually a prime.</param>
    /// <remarks>
    /// Setting <paramref name="alreadyChecked"/> to <see langword="true"/> will effectively skip the prime check.
    /// This can obviously lead to functional problems later on if handled incorrectly. It is generally a good idea to
    /// just leave it at <see langword="false"/>.
    /// </remarks>
    /// <exception cref="ArgumentException"/>
    public PrimeInteger(UInt32 source,
                        Boolean alreadyChecked = false)
    {
        if (!alreadyChecked &&
            !PrimeGenerator.IsPrime(source))
        {
            throw new ArgumentException(message: CAN_ONLY_IMPLICITLY_CONVERT_TO_PRIME);
        }

        this.Value = source;
    }

    /// <inheritdoc/>
    public readonly override Boolean Equals([NotNullWhen(true)] Object? obj)
    {
        return (obj is PrimeInteger other &&
               this.Equals(other)) ||
               (obj is UInt32 otherValue &&
               this.Equals(otherValue));
    }

    /// <inheritdoc/>
    public readonly override Int32 GetHashCode()
    {
        return this.Value.GetHashCode();
    }

    /// <inheritdoc/>
    public readonly override String ToString()
    {
        return this.Value.ToString();
    }

    /// <summary>
    /// Gets the actual value of the struct.
    /// </summary>
    public UInt32 Value
    {
        get;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private const String CAN_ONLY_IMPLICITLY_CONVERT_TO_PRIME = "Only a prime number can be assigned to this type.";
}