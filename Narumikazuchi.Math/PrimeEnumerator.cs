using Narumikazuchi.Math.Numerics;

namespace Narumikazuchi.Math;

/// <summary>
/// Enumerates through a list of prime numbers.
/// </summary>
public partial struct PrimeEnumerator
{
    /// <summary>
    /// Gets the <see cref="IEnumerator{T}"/> for this <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <returns>Itself, if the enumeration has not yet started; else a clone of itself.</returns>
    public readonly PrimeEnumerator GetEnumerator()
    {
        if (m_State.HasValue)
        {
            return new(values: m_Values,
                       startPoint: m_StartPoint,
                       endPoint: m_EndPoint);
        }
        else
        {
            return this;
        }
    }
    
    internal PrimeEnumerator(ImmutableArray<UInt32> values,
                             UInt32 startPoint,
                             UInt32 endPoint)
    {
        m_Values = values;
        m_StartPoint = startPoint;
        m_EndPoint = endPoint;
        m_Current = default;
        m_Index = 0;
        m_State = default;

        while (m_Values[m_Index] < m_StartPoint)
        {
            m_Index++;
        }

        m_Index--;
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly ImmutableArray<UInt32> m_Values;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly UInt32 m_StartPoint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly UInt32 m_EndPoint;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private PrimeInteger? m_Current;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Int32 m_Index;
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private Boolean? m_State;
}