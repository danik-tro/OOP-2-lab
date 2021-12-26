namespace AirClub.Engines;

public class NonEngine : Engine
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public virtual string Name { get; init; } = "Non engine device";

    public NonEngine() : base("")
    {
        
    }

    public override object Clone()
    {
        return new NonEngine();
    }

    public override bool IsElectric()
    {
        return false;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}