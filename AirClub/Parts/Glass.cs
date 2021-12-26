namespace AirClub.Parts;

public class Glass : Part
{
    public Glass(string name) : base(name) {}
    
    public override object Clone()
    {
        return new Glass(Name);
    }
}
