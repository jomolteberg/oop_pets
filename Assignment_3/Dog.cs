namespace assignment_3;

public class Dog : Pet
{
    public Dog(string name) : base(name)
    {
        Noise = "woof grr";
        Trick = "play dead";
    }
}