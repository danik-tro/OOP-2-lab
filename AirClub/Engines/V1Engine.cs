namespace AirClub.Engines;

public class V1Engine : Engine
{
    public static string EngineName = "V1Engine";
    
    public V1Engine(int year) : base(year)
    {
    }
    
    public override string Describe()
    {
        return $"{EngineName}:{SerialNumber}:{Year}";
    }
    
    public override object Clone()
    {
        return new V1Engine(this.Year);
    }
}