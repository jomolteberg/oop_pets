namespace assignment_3;

public class Pet
{

    protected string Name { get; set; }
    protected string Noise { get; set; }
    protected string Trick { get; set; }

    public Pet(string name)
    {
        Name = name;
    }
    public string GetName(string name)
    {
        return Name;
    } 
    public string GetNoise(string noise)
    {
        return Noise;
    } 
    public string GetTrick(string trick)
    {
        return Trick;
    }
}