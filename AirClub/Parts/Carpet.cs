namespace AirClub.Parts;


public class Carpet : Part
{
    public Carpet(string name) : base(name) {}
    
    public override object Clone()
    {
        return new Carpet(Name);
    }
}

