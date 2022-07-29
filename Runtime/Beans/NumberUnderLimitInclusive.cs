using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class GenericUnderLimitInclusiveAsBoolean<N, J> : PrimitiveToBoolean where J : A_GenericUnderLimitInclusiveSetup<N>
{
    [SerializeField] N m_value;
    public J m_limit;
    public override void GetBoolean(out bool isTrue)
        => m_limit.ComputeBoolean(in m_value, out isTrue);
    public void SetValue(in N value) => m_value = value;
}
[System.Serializable]
public abstract class A_GenericUnderLimitInclusiveSetup<N> : AbstractCanComputeBoolean<N>
{
    public A_GenericUnderLimitInclusiveSetup()
    { }
    public A_GenericUnderLimitInclusiveSetup(N from, N to)
    { m_limit = from; }
    public N m_limit;
    public bool m_isEquals = true;

}

[System.Serializable]
public class ByteUnderLimitInclusiveSetup : A_GenericUnderLimitInclusiveSetup<byte>
{
    public override void ComputeBoolean(in byte givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueUnder(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}
[System.Serializable]
public class FloatUnderLimitInclusiveSetup : A_GenericUnderLimitInclusiveSetup<float>
{
    public override void ComputeBoolean(in float givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueUnder(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}



[System.Serializable]
public class DoubleUnderLimitInclusiveSetup : A_GenericUnderLimitInclusiveSetup<double>
{
    public override void ComputeBoolean(in double givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueUnder(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}

[System.Serializable]
public class IntUnderLimitInclusiveSetup : A_GenericUnderLimitInclusiveSetup<int>
{
    public override void ComputeBoolean(in int givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueUnder(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}

[System.Serializable]
public class LongUnderLimitInclusiveSetup : A_GenericUnderLimitInclusiveSetup<long>
{
    public override void ComputeBoolean(in long givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueUnder(out isTrue,
            in givenValue, in m_limit, in m_isEquals);
    }
}






[System.Serializable]
public class ByteUnderLimitInclusiveAsBoolean : GenericUnderLimitInclusiveAsBoolean<byte, ByteUnderLimitInclusiveSetup> { }
[System.Serializable]
public class FloatUnderLimitInclusiveAsBoolean : GenericUnderLimitInclusiveAsBoolean<float, FloatUnderLimitInclusiveSetup> { }
[System.Serializable]
public class DoubleUnderLimitInclusiveAsBoolean : GenericUnderLimitInclusiveAsBoolean<double, DoubleUnderLimitInclusiveSetup> { }
[System.Serializable]
public class IntUnderLimitInclusiveAsBoolean : GenericUnderLimitInclusiveAsBoolean<int, IntUnderLimitInclusiveSetup> { }
[System.Serializable]
public class LongUnderLimitInclusiveAsBoolean : GenericUnderLimitInclusiveAsBoolean<long, LongUnderLimitInclusiveSetup> { }
