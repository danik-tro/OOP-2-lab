namespace AirClub.Devices;

using Engines;
using Parts;

public class Helicopter<T, U> : Device<T, U>
    where T: Part
    where U: Engine
{
    public override string NameDevice { get; init; } = "Helicopter";

    public Helicopter(string model) : base(model) { }
    
    public Helicopter(string model, U engine) : base(model, engine) {}
    
    public Helicopter(string model, List<T> parts) : base(model, parts) {}

    public Helicopter(string model, U engine, List<T> parts) : base(model, engine, parts) {}

    public override object Clone()
    {
        return new Helicopter<T, U>(Model, DeviceEngine, parts);
    }
}



