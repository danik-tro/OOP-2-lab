namespace AirClub.Parts;
public abstract class Part : IPart, ICloneable
{
    protected string SerialNumber;
    protected string _name;
    protected int _year;

    public string Name
    {
        get;
    }

    public int Year
    {
        get;
    }
    
    public Part(string name, int year)
    {
        SerialNumber = GenerateId();
        _name = name;
        _year = year;
    }
    
    public string GenerateId()
    {
        return Guid.NewGuid().ToString();
    }

    public abstract object Clone();
    
    public override string ToString()
    {
        return Describe();
    }

    public string Describe()
    {
        return $"{Name} - {SerialNumber}:{Year}";
    }
}