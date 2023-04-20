using _10_InterfaceAlapok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfaceAlapok.Animals
{
    internal class Pelican : IAnimal, ICanSwimAndFly
    {
        public Pelican(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("The pelican is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("The pelican is swimming");
        }
    }
}
