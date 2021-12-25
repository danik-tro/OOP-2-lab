namespace AirClub.Devices;
using AirClub.Parts;


public abstract class NonEngineDevice : Device
{
    protected NonEngineDevice() : base()
    {
    }
    
    public NonEngineDevice(string model) : base(model)
    {
    }
    
    public NonEngineDevice(string model, List<Part> parts) : base(model, parts)
    {
    }
}