namespace AirClub;
using AirClub.Devices;
using AirClub.Parts;
using AirClub.Engines;


public class Register<V, T, U>
    where V: Device<T, U>
    where U: Engine
    where T: Part
{
    private List<V> devices = new List<V>();
    
    public string Name { get; init; }

    public void AddDevice(V device)
    {
        devices.Add((V)device.Clone());
    }
    
    public void AddDevices(List<V> devices)
    {
        foreach (var device in devices)
        {
            AddDevice(device);
        }
    }

    public IEnumerable<V> ElectricDevices()
    {
        return from device in devices
            where device.engine.IsElectric()
            select device;
    }
    
    public IEnumerable<V> NonElectricDevices()
    {
        return from device in devices
            where !device.engine.IsElectric()
            select device;
    }
    
    public Register(string name)
    {
        Name = name;
    }
}