// See https://aka.ms/new-console-template for more information

using assignment_3;

Fish nemo = new("Nemo");
Fish bubbles = new("Bubbles");
Cat graig = new("Graig");
Cat pusur = new("Pusur");
Dog fido = new("Fido");
Dog oscar = new("Oscar");

List<Pet> animals = [nemo, bubbles, graig, pusur, fido, oscar];
foreach (Pet pet in animals)
{
    Console.WriteLine($"Type: {pet.GetType().Name}, Name: {pet.GetName("")}, Noise: {pet.GetNoise("")}, Trick: {pet.GetTrick("")}");
}