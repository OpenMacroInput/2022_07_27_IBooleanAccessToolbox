using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BooleanUtility_Primitive
{


    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
  in byte value, in byte fromMin, in byte toMax, in bool includeMin, in bool includeMax)
  => isTrue = (includeMin ? value >= fromMin : value > fromMin) && (includeMax ? value <= toMax : value < toMax);

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
       in byte value, in byte fromMin, in byte toMax)
        => isTrue = value > fromMin && value < toMax;


    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
   in int value, in int fromMin, in int toMax, in bool includeMin, in bool includeMax)
   => isTrue = (includeMin ? value >= fromMin : value > fromMin) && (includeMax ? value <= toMax : value < toMax);

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
       in int value, in int fromMin, in int toMax)
        => isTrue = value > fromMin && value < toMax;


    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
        in float value, in float fromMin, in float toMax, in bool includeMin, in bool includeMax)
        =>  isTrue = (includeMin? value >= fromMin: value > fromMin ) && (includeMax ? value <= toMax : value < toMax);

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
       in float value, in float fromMin, in float toMax)
        => isTrue = value > fromMin && value < toMax;

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
    in double value, in double fromMin, in double toMax, in bool includeMin, in bool includeMax)
    => isTrue = (includeMin ? value >= fromMin : value > fromMin) && (includeMax ? value <= toMax : value < toMax);

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
       in double value, in double fromMin, in double toMax)
        => isTrue = value > fromMin && value < toMax;

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
 in long value, in long fromMin, in long toMax, in bool includeMin, in bool includeMax)
 => isTrue = (includeMin ? value >= fromMin : value > fromMin) && (includeMax ? value <= toMax : value < toMax);

    public static void IsValueBetween(this BooleanUtility obj, out bool isTrue,
       in long value, in long fromMin, in long toMax)
        => isTrue = value > fromMin && value < toMax;







    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
  in byte value, in byte limit, in bool andEqual)
  => isTrue = andEqual ? value <= limit : value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
       in byte value, in byte limit)
        => isTrue = value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
   in int value, in int limit, in bool andEqual)
   => isTrue = andEqual ? value <= limit : value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
       in int value, in int limit)
        => isTrue = value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
        in float value, in float limit, in bool andEqual)
        => isTrue = andEqual ? value <= limit : value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
       in float value, in float limit)
        => isTrue = value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
    in double value, in double limit, in bool andEqual)
    => isTrue = andEqual ? value <= limit : value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
       in double value, in double limit)
        => isTrue = value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
 in long value, in long limit, in bool andEqual)
 => isTrue = andEqual ? value <= limit : value < limit;
    public static void IsValueUnder(this BooleanUtility obj, out bool isTrue,
       in long value, in long limit)
        => isTrue = value < limit;


    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
  in byte value, in byte limit, in bool andEqual)
  => isTrue = andEqual ? value >= limit : value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
       in byte value, in byte limit)
        => isTrue = value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
   in int value, in int limit, in bool andEqual)
   => isTrue = andEqual ? value >= limit : value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
       in int value, in int limit)
        => isTrue = value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
        in float value, in float limit, in bool andEqual)
        => isTrue = andEqual ? value >= limit : value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
       in float value, in float limit)
        => isTrue = value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
    in double value, in double limit, in bool andEqual)
    => isTrue = andEqual ? value >= limit : value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
       in double value, in double limit)
        => isTrue = value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
 in long value, in long limit, in bool andEqual)
 => isTrue = andEqual ? value >= limit : value > limit;
    public static void IsValueOver(this BooleanUtility obj, out bool isTrue,
       in long value, in long limit)
        => isTrue = value > limit;

}




[System.Serializable]
public class GenericBetweenRangeInclusiveAsBoolean<N, J> : PrimitiveToBoolean where J: A_GenericBetweenRangeInclusiveSetup<N>
{
    [SerializeField] N m_value;
    public J m_limit;
    public override void GetBoolean(out bool isTrue)
        => m_limit.ComputeBoolean(in m_value, out isTrue);
    public void SetValue(in N value) => m_value = value;
}
[System.Serializable]
public abstract class A_GenericBetweenRangeInclusiveSetup<N> : AbstractCanComputeBoolean<N>
{
    public A_GenericBetweenRangeInclusiveSetup()
    { }
    public A_GenericBetweenRangeInclusiveSetup(N from, N to)
    { m_fromMinValue = from; m_toMaxValue = to; }
    public N m_fromMinValue;
    public bool m_includeMin = true;
    public N m_toMaxValue;
    public bool m_includeMax = true;
    //public abstract void ComputeBoolean(in N givenValue, out bool isTrue);
   
}

[System.Serializable]
public  class ByteBetweenRangeInclusiveSetup : A_GenericBetweenRangeInclusiveSetup<byte>
{
    public override void ComputeBoolean(in byte givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueBetween(out isTrue,
            in givenValue, in m_fromMinValue, in m_toMaxValue,
            in m_includeMin, in m_includeMax);
    }
}
[System.Serializable]
public  class FloatBetweenRangeInclusiveSetup : A_GenericBetweenRangeInclusiveSetup<float>
{
    public override void ComputeBoolean(in float givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueBetween(out isTrue,
            in givenValue, in m_fromMinValue, in m_toMaxValue,
            in m_includeMin, in m_includeMax);
    }
}



[System.Serializable]
public  class DoubleBetweenRangeInclusiveSetup : A_GenericBetweenRangeInclusiveSetup<double>
{
    public override void ComputeBoolean(in double givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueBetween(out isTrue,
            in givenValue, in m_fromMinValue, in m_toMaxValue,
            in m_includeMin, in m_includeMax);
    }
}

[System.Serializable]
public  class IntBetweenRangeInclusiveSetup : A_GenericBetweenRangeInclusiveSetup<int>
{
    public override void ComputeBoolean(in int givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueBetween(out isTrue,
            in givenValue, in m_fromMinValue, in m_toMaxValue,
            in m_includeMin, in m_includeMax);
    }
}

[System.Serializable]
public  class LongBetweenRangeInclusiveSetup : A_GenericBetweenRangeInclusiveSetup<long>
{
    public override void ComputeBoolean(in long givenValue, out bool isTrue)
    {
        BooleanUtility.I.IsValueBetween(out isTrue,
            in givenValue, in m_fromMinValue, in m_toMaxValue,
            in m_includeMin, in m_includeMax);
    }
}






[System.Serializable]
public class ByteBetweenRangeInclusiveAsBoolean : GenericBetweenRangeInclusiveAsBoolean<byte, ByteBetweenRangeInclusiveSetup> { }
[System.Serializable]
public class FloatBetweenRangeInclusiveAsBoolean : GenericBetweenRangeInclusiveAsBoolean<float, FloatBetweenRangeInclusiveSetup> { }
[System.Serializable]
public class DoubleBetweenRangeInclusiveAsBoolean : GenericBetweenRangeInclusiveAsBoolean<double, DoubleBetweenRangeInclusiveSetup> { }
[System.Serializable]
public class IntBetweenRangeInclusiveAsBoolean : GenericBetweenRangeInclusiveAsBoolean<int, IntBetweenRangeInclusiveSetup> { }
[System.Serializable]
public class LongBetweenRangeInclusiveAsBoolean : GenericBetweenRangeInclusiveAsBoolean<long, LongBetweenRangeInclusiveSetup> { }
