namespace Assignment1.OOP.Polymorphism
{
    internal class DogPolymorphism : AnimalPolymorphism
    {
        public override void animalSound()
        {
            Console.WriteLine("Köpek Sesi!");
        }
    }
}
