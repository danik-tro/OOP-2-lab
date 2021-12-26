namespace AirClub.Parts;

public abstract class Part : IPart, ICloneable
{
    public string Name { get; init; }
    public string Id { get; init; } = Guid.NewGuid().ToString();

    public Part(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"{Name}:{Id}";
    }

    public abstract object Clone();
}