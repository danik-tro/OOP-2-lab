namespace AirClub.Parts;


public class Cabin : Part
{
    public Cabin(string name) : base(name) {}
    
    public override object Clone()
    {
        return new Cabin(Name);
    }
}
