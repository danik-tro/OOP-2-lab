namespace AirClub.Devices;
using Parts;
using Engines;

public class Plane<T, U> : Device<T, U>
where T: Part
where U: Engine
{
    public override string NameDevice { get; init; } = "Plane";

    public Plane(string model) : base(model) { }
    
    public Plane(string model, U engine) : base(model, engine) {}
    
    public Plane(string model, List<T> parts) : base(model, parts) {}

    public Plane(string model, U engine, List<T> parts) : base(model, engine, parts) {}

    public override object Clone()
    {
        return new Plane<T, U>(Model, DeviceEngine, parts);
    }
}