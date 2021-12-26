namespace AirClub.Parts;

public class Wing : Part
{
    public Wing(string name) : base(name) {}
    
    public override object Clone()
    {
        return new Wing(Name);
    }
}