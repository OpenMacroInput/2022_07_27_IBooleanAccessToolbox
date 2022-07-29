using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_BooleanAccessToolbox : MonoBehaviour
{

    public DoubleUnderLimitInclusiveAsBoolean m_underValue;
    public bool m_underValueResult;
    public DoubleOverLimitInclusiveAsBoolean m_overValue;
    public bool m_overValueResult;


    public ByteBetweenRangeInclusiveAsBoolean m_byteLimit;
    public bool m_byteLimitResult;
    public FloatBetweenRangeInclusiveAsBoolean m_floatLimit;
    public bool m_floatLimitResult;
    public DoubleBetweenRangeInclusiveAsBoolean m_doubleLimit;
    public bool m_doubleLimitResult;
    public IntBetweenRangeInclusiveAsBoolean m_intLimit;
    public bool m_intLimitResult;
    public LongBetweenRangeInclusiveAsBoolean m_longLimit;
    public bool m_longLimitResult;


    void Update()
    {
        m_byteLimit.GetBoolean(out m_byteLimitResult);
        m_floatLimit.GetBoolean(out m_floatLimitResult);
        m_doubleLimit.GetBoolean(out m_doubleLimitResult);
        m_intLimit.GetBoolean(out m_intLimitResult);
        m_longLimit.GetBoolean(out m_longLimitResult);

        m_underValue.GetBoolean(out m_underValueResult);
        m_overValue.GetBoolean(out m_overValueResult);
    }
}
