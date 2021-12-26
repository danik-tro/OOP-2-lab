namespace AirClub.Devices;
using Engines;
using Parts;

public class FlyingCarpet<T, U> : Device<T, U>
    where T: Part
    where U: Engine
{
    public override string NameDevice { get; init; } = "Flying Carpet";

    public FlyingCarpet(string model) : base(model) { }
    
    public FlyingCarpet(string model, U engine) : base(model, engine) {}
    
    public FlyingCarpet(string model, List<T> parts) : base(model, parts) {}

    public FlyingCarpet(string model, U engine, List<T> parts) : base(model, engine, parts) {}

    public override object Clone()
    {
        return new FlyingCarpet<T, U>(Model, DeviceEngine, parts);
    }
}