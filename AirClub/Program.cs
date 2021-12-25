using AirClub.Devices;
using AirClub.Engines;
using AirClub.Parts;

namespace AirClub
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var plane = new Plane(
                "FirstPlane",
                new List<Part>
                {
                    new Wing("Right wing", 2021),
                    new Wing("Left wing", 2021),
                },
                new V1Engine(2021)
                );
            Console.WriteLine(plane);
        }
    }
}

