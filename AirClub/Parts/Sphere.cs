namespace AirClub.Parts;

public class Sphere : Part
{
    public Sphere(string name) : base(name) {}
    
    public override object Clone()
    {
        return new Sphere(Name);
    }
}