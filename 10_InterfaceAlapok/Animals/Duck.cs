using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10_InterfaceAlapok.Interfaces;

namespace _10_InterfaceAlapok.Animals
{
    internal class Duck : IAnimal, ICanFly
    {
        public Duck(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("The duck is flying.");
        }
    }
}
