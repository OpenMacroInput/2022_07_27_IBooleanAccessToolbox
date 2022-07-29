using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBooleanDelegateAccessGet : IBooleanAccessGet
{
    public delegate bool D_GetBoolean();
    public bool IsGetDefined();
    public void SetAccessToBoolean(in IBooleanDelegateAccessGet.D_GetBoolean getBoolAcces);
}
public interface IBooleanDelegateAccessSet : IBooleanAccessSet  
{
    public delegate void D_SetBoolean(in bool value);
    public bool IsSetDefined();
    public void SetAccessToBoolean(in IBooleanDelegateAccessSet.D_SetBoolean setBoolAcces);
}

[System.Serializable]
public class DelegateBooleanAccessGet : IBooleanDelegateAccessGet
{

    IBooleanDelegateAccessGet.D_GetBoolean m_getBoolAcces;
    public bool IsGetterDefined() { return m_getBoolAcces != null; }
    public DelegateBooleanAccessGet()
    {
    }
    public DelegateBooleanAccessGet(IBooleanDelegateAccessGet.D_GetBoolean getBoolAcces)
    {
        m_getBoolAcces = getBoolAcces;
    }

    public void GetBoolean(out bool value)
    {
        if (m_getBoolAcces != null)
            value = m_getBoolAcces();
        else
            value = false;
    }

    public bool GetBoolean()
    {
        if (m_getBoolAcces != null)
            return m_getBoolAcces();
        else
            return false;
    }

    public void SetAccessToBoolean(in IBooleanDelegateAccessGet.D_GetBoolean getBoolAcces)
    {
        m_getBoolAcces = getBoolAcces;
    }

    public bool IsGetDefined()
    {
       return m_getBoolAcces != null;
    }
}


[System.Serializable]
public class DelegateBooleanAccessSet : IBooleanDelegateAccessSet
{
    
    IBooleanDelegateAccessSet.D_SetBoolean m_setBoolAcces;
    public bool IsSetterDefined() { return m_setBoolAcces != null ; }

    public DelegateBooleanAccessSet()
    {
    }

    
    public DelegateBooleanAccessSet(IBooleanDelegateAccessSet.D_SetBoolean setBoolAcces)
    {
        m_setBoolAcces = setBoolAcces;
    }


    public void SetBoolean(in bool isTrue)
    {
        if (m_setBoolAcces != null)
            m_setBoolAcces(isTrue);
    }

    public void SetAccessToBoolean(in IBooleanDelegateAccessSet.D_SetBoolean setBoolAcces)
    {
        m_setBoolAcces = setBoolAcces;
    }

    public bool IsSetDefined()
    {
        return m_setBoolAcces!=null;
    }
}



[System.Serializable]
public class DelegateBooleanAccess : IBooleanDelegateAccessGet, IBooleanDelegateAccessSet
{

    IBooleanDelegateAccessGet.D_GetBoolean m_getBoolAcces;
    public bool IsGetterDefined() { return m_getBoolAcces != null; }

    IBooleanDelegateAccessSet.D_SetBoolean m_setBoolAcces;
    public bool IsSetterDefined() { return m_setBoolAcces != null; }


    public DelegateBooleanAccess()
    {}
    public DelegateBooleanAccess(
        IBooleanDelegateAccessGet.D_GetBoolean getBoolAcces, 
        IBooleanDelegateAccessSet.D_SetBoolean setBoolAcces)
    {
        m_getBoolAcces = getBoolAcces;
        m_setBoolAcces = setBoolAcces;
    }

    public void GetBoolean(out bool value)
    {
        if (m_getBoolAcces != null)
            value = m_getBoolAcces();
        else
            value = false;
    }

    public bool GetBoolean()
    {
        if (m_getBoolAcces != null)
            return m_getBoolAcces();
        else
            return false;
    }

  
    public void SetBoolean(in bool isTrue)
    {
        if (m_setBoolAcces != null)
            m_setBoolAcces(isTrue);
    }
    public void SetAccessToBoolean(in IBooleanDelegateAccessSet.D_SetBoolean setBoolAcces)
    {
        m_setBoolAcces = setBoolAcces;
    }
    public void SetAccessToBoolean(in IBooleanDelegateAccessGet.D_GetBoolean getBoolAcces)
    {
        m_getBoolAcces = getBoolAcces;
    }

    public bool IsGetDefined()
    {
        return m_getBoolAcces != null;
    }
    public bool IsSetDefined()
    {
        return m_setBoolAcces != null;
    }
}