namespace AirClub.Devices;
using Parts;
using Engines;

class PartsLengthComparer : IComparer<Device<Part, Engine>>
{
    public int Compare(Device<Part, Engine> d1, Device<Part, Engine> d2)
    {
        if (d1.parts.Count > d2.parts.Count)
            return 1;
        if (d1.parts.Count < d2.parts.Count)
            return -1;
        return 0;
    }
}