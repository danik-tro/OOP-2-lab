namespace AirClub.Devices;
using Engines;
using Parts;


public abstract class Device<T, U>: IDevice, ICloneable, IComparable
    where T: Part
    where U: Engine
{
    protected internal U engine;
    protected internal List<T> parts = new List<T>();
    
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public virtual U DeviceEngine
    {
        get => engine;
        init
        {
            if (value is null)
                throw new Exception("Engine is null.");
            engine = value;
        }
    }

    public virtual string NameDevice { get; init; } = "";
    
    public string Model { get; }

    public Device(string model)
    {
        Model = model;
    }
    
    public Device(string model, U engine) : this(model)
    {
        DeviceEngine = engine;
    }
    
    public Device(string model, List<T> parts) : this(model)
    {
        AddParts(parts);
    }

    public Device(string model, U engine, List<T> parts) : this(model, engine)
    {
        AddParts(parts);
    }

    public void AddParts(in List<T> parts)
    {
        this.parts.AddRange(parts);
    }
    
    public void AddPart(in T part)
    {
        parts.Add((T)part.Clone());
    }

    public override string ToString()
    {
        return String.Concat(
            $"Device: {NameDevice}:{Model}:{Id}\n\rEngine: {DeviceEngine}\nParts:\n\t * ",
            String.Join("\n\t * ", parts)
            );
    }

    public virtual void Prepare()
    {
        Console.WriteLine($"Prepare device {Id}:{NameDevice}:{Model}");
    }

    public virtual int CompareTo(object o)
    {
        var device = o as Device<Part, Engine>;

        return this.NameDevice.CompareTo(device.NameDevice);
    }
    
    public abstract object Clone();
}