using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GenericOverLimitInclusiveAsBoolean<N, J> : PrimitiveToBoolean where J : A_GenericOverLimitInclusiveSetup<N>
{
    [SerializeField] N m_value;
    public J m_limit;
    public override void GetBoolean(out bool isTrue)
        => m_limit.ComputeBoolean(in m_value, out isTrue);
    public void SetValue(in N value) => m_value = value;
}
[System.Serializable]
public abstract class A_GenericOverLimitInclusiveSetup<N> : AbstractCanComputeBoolean<N>
{
    public A_GenericOverLimitInclusiveSetup()
    { }
    public A_GenericOverLimitInclusiveSetup(N from, N to)
    { m_limit = from; }
    public N m_limit;
    public bool m_isEquals = true;
}

[System.Serializable]
public class ByteOverLimitInclusiveSetup : A_GenericOverLimitInclusiveSetup<byte>
{
    public override void ComputeBoolean(in byte givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueOver(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}
[System.Serializable]
public class FloatOverLimitInclusiveSetup : A_GenericOverLimitInclusiveSetup<float>
{
    public override void ComputeBoolean(in float givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueOver(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}



[System.Serializable]
public class DoubleOverLimitInclusiveSetup : A_GenericOverLimitInclusiveSetup<double>
{
    public override void ComputeBoolean(in double givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueOver(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}

[System.Serializable]
public class IntOverLimitInclusiveSetup : A_GenericOverLimitInclusiveSetup<int>
{
    public override void ComputeBoolean(in int givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueOver(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}

[System.Serializable]
public class LongOverLimitInclusiveSetup : A_GenericOverLimitInclusiveSetup<long>
{
    public override void ComputeBoolean(in long givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueOver(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}

[System.Serializable]
public class ByteOverLimitInclusiveAsBoolean : GenericOverLimitInclusiveAsBoolean<byte, ByteOverLimitInclusiveSetup> { }
[System.Serializable]
public class FloatOverLimitInclusiveAsBoolean : GenericOverLimitInclusiveAsBoolean<float, FloatOverLimitInclusiveSetup> { }
[System.Serializable]
public class DoubleOverLimitInclusiveAsBoolean : GenericOverLimitInclusiveAsBoolean<double, DoubleOverLimitInclusiveSetup> { }
[System.Serializable]
public class IntOverLimitInclusiveAsBoolean : GenericOverLimitInclusiveAsBoolean<int, IntOverLimitInclusiveSetup> { }
[System.Serializable]
public class LongOverLimitInclusiveAsBoolean : GenericOverLimitInclusiveAsBoolean<long, LongOverLimitInclusiveSetup> { }
