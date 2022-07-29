using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_DelegateBooleanAccess : MonoBehaviour
{
    public DelegateBooleanAccessGet m_getterBoolean= new DelegateBooleanAccessGet();
    public DelegateBooleanAccessSet m_setterBoolean = new DelegateBooleanAccessSet();
    public DelegateBooleanAccess m_getSetBoolean = new DelegateBooleanAccess();
    public bool[] m_value= new bool[2];
    public bool m_dateModulo;
    public bool m_arrayValue;
    void Start()
    {
        m_getterBoolean.SetAccessToBoolean(() => { return DateTime.Now.Second % 3 == 0; });
        m_getSetBoolean.SetAccessToBoolean(() => { return m_value[0]; });
        m_getSetBoolean.SetAccessToBoolean((in bool value) => { m_value[0] = value; });
        m_setterBoolean.SetAccessToBoolean((in bool value) => { m_value[1] = value; });
    }

    void Update()
    {
        if (m_setterBoolean.IsSetDefined())
            m_setterBoolean.SetBoolean(Input.GetKey(KeyCode.Space));
        if (m_getSetBoolean.IsSetDefined())
            m_getSetBoolean.SetBoolean(Input.GetKey(KeyCode.LeftControl));
        if (m_getterBoolean.IsGetDefined())
            m_getterBoolean.GetBoolean(out m_dateModulo);
        if (m_getSetBoolean.IsGetDefined())
            m_getSetBoolean.GetBoolean(out m_arrayValue);
    }
}
