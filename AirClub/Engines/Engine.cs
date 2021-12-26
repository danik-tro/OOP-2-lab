namespace AirClub.Engines;

public abstract class Engine : IEngine, ICloneable
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public virtual string Name { get; init; } = "";
    public string Model { get; init; }

    public Engine(string model) => Model = model;
    
    public abstract object Clone();
    public override string ToString()
    {
        return $"{Name}:{Model}:{Id}";
    }

    public virtual bool IsElectric()
    {
        return true;
    }
}