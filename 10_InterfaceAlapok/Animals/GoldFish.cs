using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_InterfaceAlapok.Interfaces;

namespace _10_InterfaceAlapok.Animals
{
    internal class GoldFish : IAnimal, ICanSwim
    {

        public GoldFish(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Swim()
        {
            Console.WriteLine("The gold fish is swimming.");
        }
    }
}
