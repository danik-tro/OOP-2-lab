namespace AirClub.Engines;

public class EngineV1 : Engine
{
    public override string Name { get; init; } = "EngineV1";
    
    public EngineV1(string model) : base(model) {}

    public override object Clone()
    {
        return new EngineV1(Model);
    }
}