namespace AirClub.Devices;

using Engines;
using Parts;

public class Balloon<T, U> : Device<T, U>
    where T: Part
    where U: Engine
{
    public override string NameDevice { get; init; } = "Balloon";

    public Balloon(string model) : base(model) { }
    
    public Balloon(string model, U engine) : base(model, engine) {}
    
    public Balloon(string model, List<T> parts) : base(model, parts) {}

    public Balloon(string model, U engine, List<T> parts) : base(model, engine, parts) {}

    public override object Clone()
    {
        return new Balloon<T, U>(Model, DeviceEngine, parts);
    }
}
