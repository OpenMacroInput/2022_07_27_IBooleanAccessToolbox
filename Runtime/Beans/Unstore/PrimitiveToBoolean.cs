

[System.Serializable]
public abstract class PrimitiveToBoolean : IBooleanAccessGet
{
    public abstract void GetBoolean(out bool isTrue);
    public bool GetBoolean()
    {
        GetBoolean(out bool isTrue); return isTrue;
    }
}