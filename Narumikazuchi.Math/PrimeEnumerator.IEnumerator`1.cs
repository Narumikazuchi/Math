using Narumikazuchi.Math.Numerics;

namespace Narumikazuchi.Math;

public partial struct PrimeEnumerator : IEnumerator<PrimeInteger>
{
    /// <inheritdoc/>
    public Boolean MoveNext()
    {
        if (m_State.HasValue &&
            !m_State.Value)
        {
            return false;
        }

        if (!m_State.HasValue)
        {
            if (m_EndPoint <= 2)
            {
                m_State = false;
                return false;
            }
            else
            {
                m_State = true;
            }
        }

        m_Index++;
        if (m_Index < m_Values.Length &&
            m_Values[m_Index] < m_EndPoint)
        {
            m_Current = new(m_Values[m_Index], true);
            return true;
        }

        m_State = false;
        return false;
    }

    /// <inheritdoc/>
    public readonly PrimeInteger Current
    {
        get
        {
            if (!m_State.HasValue ||
                !m_State.Value)
            {
                throw new InvalidOperationException();
            }

            return m_Current!.Value;
        }
    }

    readonly void IDisposable.Dispose()
    {
        GC.SuppressFinalize(this);
    }

    readonly void IEnumerator.Reset()
    { }

    readonly Object? IEnumerator.Current
    {
        get
        {
            return this.Current;
        }
    }
}