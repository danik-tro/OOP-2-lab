namespace AirClub.Devices;

public class Helicopter : ElectricalDevice
{
    public override void Move()
    {
        Console.WriteLine("Plane is moving.");
    }

    public override object Clone()
    {
        throw new NotImplementedException();
    }

    public override string Info()
    {
        Console.WriteLine("Plane info");
        Console.WriteLine("***********************");
        return "";
    }
}