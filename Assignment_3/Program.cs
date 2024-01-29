using assignment_3;


List<Pet> myPets = [];
myPets.Add(new Fish("Nemo"));
myPets.Add(new Fish("Nemo"));
myPets.Add(new Cat ("Graig"));
myPets.Add(new Cat ("Pusur"));
myPets.Add(new Dog ("Fido"));
myPets.Add(new Dog ("Oscar"));

foreach (Pet pet in myPets)
{
    Console.WriteLine($"Type: {pet.GetType().Name}, " +
                      $"Name: {pet.GetName("")}, " +
                      $"Noise: {pet.GetNoise("")}, " +
                      $"Trick: {pet.GetTrick("")}");
}