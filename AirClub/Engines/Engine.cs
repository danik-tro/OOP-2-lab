namespace AirClub.Engines;

public abstract class Engine : IEngine, ICloneable
{
    public static string EngineName = "Engine";
    
    protected string SerialNumber;
    protected int _year;

    public int Year
    {
        get;
    }
    
    public Engine(int year)
    {
        SerialNumber = GenerateId();
        _year = year;
    }
    
    public override string ToString()
    {
        return Describe();
    }
    
    public virtual string Describe()
    {
        return $"{EngineName}:{SerialNumber}:{Year}";
    }

    public abstract object Clone();
    
    public string GenerateId()
    {
        return Guid.NewGuid().ToString();
    }
}