using _10_InterfaceAlapok.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InterfaceAlapok
{
    internal class Zoo
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public List<IAnimal> Animals 
        { 
            get 
            {
                //Klónozás
                return animals;
            } 
        }

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public List<IAnimal> AnimalsThatCanSwim
        {
            get
            {
                List<IAnimal> temp = new List<IAnimal>();

                foreach (IAnimal animal in animals)
                {
                    if (animal is ICanSwim)
                    {
                        temp.Add(animal);
                    }
                }

                return temp;

            }
        }

    }
}
