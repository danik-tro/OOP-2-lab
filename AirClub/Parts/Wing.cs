namespace AirClub.Parts;

public class Wing : Part
{
    
    public Wing(string name, int year) : base(name, year)
    {
    }

    public override object Clone()
    {
        return new Wing(this.Name, this.Year);
    }
}