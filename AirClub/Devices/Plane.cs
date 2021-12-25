namespace AirClub.Devices;
using AirClub.Parts;
using AirClub.Engines;

public class Plane : ElectricalDevice
{
    public new const string DeviceName = "Plane";
    
    protected Plane() : base()
    {
    }
    
    public Plane(string model) : base(model)
    {
    }
    
    public Plane(string model, List<Part> parts) : base(model, parts)
    {
    }

    public Plane(string model, List<Part> parts, Engine engine) : base(model, parts, engine)
    {
    }
    
    public override void Move()
    {
        Console.WriteLine($"{DeviceName} is moving.");
    }

    public override object Clone()
    {
        return new Plane(_model, CloneParts(), CloneEngine());
    }
}