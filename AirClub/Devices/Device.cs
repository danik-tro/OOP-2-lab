namespace AirClub.Devices;

using System.Collections.Generic;
using AirClub.Parts;

public abstract class Device : IDevice, ICloneable
{
    public const string DeviceName = "Device";
    
    protected string _id;
    protected string _model;
    protected List<Part> _parts = new List<Part>();

    protected Device()
    {
        _id = GenerateId();
    }
    
    public Device(string model) : this()
    {
        _model = model;
    }
    
    public Device(string model, List<Part> parts) : this(model)
    {
        AddParts(parts);
    }

    public override string ToString()
    {
        return Info();
    }

    public string PartsInfo()
    {
        return String.Join("\n\r* ", _parts);
    }
    
    public string GenerateId()
    {
        return Guid.NewGuid().ToString();
    }

    public List<Part> CloneParts()
    {
        var parts = new List<Part>();
        foreach (var part in _parts)
        {
            parts.Add(part);
        }

        return parts;
    }
    
    public void AddParts(List<Part> parts)
    {
        foreach (var part in parts)
        {
            AddPart(part);
        }
    }
    
    public void AddPart(Part part)
    {
        this._parts.Add((Part)part.Clone());
    }
    
    public abstract void Move();
    
    public abstract string Info();
    public abstract object Clone();
}

