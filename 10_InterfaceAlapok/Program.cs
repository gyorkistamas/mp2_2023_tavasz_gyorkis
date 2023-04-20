using _10_InterfaceAlapok.Animals;
using _10_InterfaceAlapok.Interfaces;

namespace _10_InterfaceAlapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Duck("Duck 1"));

            zoo.AddAnimal(new Duck("Duck 2"));

            zoo.AddAnimal(new GoldFish("GoldFish 1"));

            zoo.AddAnimal(new GoldFish("GoldFish 2"));

            zoo.AddAnimal(new Pelican("Pelican 1"));

            foreach(IAnimal animal in zoo.Animals)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("Animals that can swim:");
            foreach(IAnimal animal in zoo.AnimalsThatCanSwim)
            {
                Console.WriteLine(animal.Name);
                (animal as ICanSwim).Swim();
            }

            Pelican pelican = new Pelican("Pelican 2");

            Console.WriteLine(pelican.Name);
            pelican.Swim();
            pelican.Fly();

            Console.ReadLine();
        }
    }
}