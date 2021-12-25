namespace AirClub.Devices;

using AirClub.Engines;
using AirClub.Parts;

public abstract class ElectricalDevice : Device
{
    protected Engine _engine;
    
    protected ElectricalDevice() : base()
    {
    }
    
    public ElectricalDevice(string model) : base(model)
    {
    }
    
    public ElectricalDevice(string model, List<Part> parts) : base(model, parts)
    {
    }

    public ElectricalDevice(string model, List<Part> parts, Engine engine) : this(model, parts)
    {
        _engine = engine;
    }

    public Engine Engine
    {
        set => _engine = value;
    }

    public Engine CloneEngine()
    {
        return (Engine) _engine.Clone();
    }
    
    public override string Info()
    {
        return String.Concat(
            $"{DeviceName}\n",
            $"* {EngineInfo()}\n",
            PartsInfo()
            );
    }
    
    public string EngineInfo()
    {
        return _engine.ToString();
    }
}