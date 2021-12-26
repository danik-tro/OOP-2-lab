using AirClub.Devices;
using AirClub.Engines;
using AirClub.Parts;

namespace AirClub
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var devices = new List<Device<Part, Engine>>
            {
                new Plane<Part, Engine>(
                    "Plane1V1",
                    new EngineV1("EngineV1ModelS"),
                    new List<Part>
                    {
                        new Wing("Right wing"),
                        new Wing("Left wing"),
                        new Cabin("Main cabin"),
                        new Glass("Cabins glass")
                    }
                ),
                new Helicopter<Part, Engine>(
                    "HelicopterV1",
                    new EngineV1("EngineV1ModelS"),
                    new List<Part>
                    {
                        new Wing("Right wing"),
                        new Wing("Left wing"),
                        new Cabin("Main cabin"),
                        new Glass("Cabins glass")
                    }
                ),
                new FlyingCarpet<Part, Engine>(
                    "Aladin Carpet",
                    new NonEngine(),
                    new List<Part>
                    {
                        new Carpet("Aladin Carpet")
                    }
                ),
                new Balloon<Part, Engine>(
                    "Balloon",
                    new NonEngine(),
                    new List<Part>
                    {
                        new Carpet("Sphere")
                    }
                )
            };

            var airClub = new Register<Device<Part, Engine>, Part, Engine>("AirClub");
            airClub.AddDevices(devices);

            Console.WriteLine(
                String.Concat(
                    "Electric devices: \n", 
                    String.Join("\n", airClub.ElectricDevices()
                    ))
                );

            Console.WriteLine(
                String.Concat(
                    "Non-Electric devices: \n", 
                    String.Join("\n", airClub.NonElectricDevices()
                    ))
            );
            
            // Sort by parts length
            devices.Sort(new PartsLengthComparer());
            
            Console.WriteLine(String.Join("\n", devices));
            
            // Sort by device name
            devices.Sort();
            Console.WriteLine(String.Join("\n", devices));
        }
    }
}

