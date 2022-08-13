using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.OOP.Encapsulation
{
    internal class AnimalEncapsulation
    {
        public string name1 = "Dog";
        private string name2 = "Cat";

        public void animalSound()
        {
            Console.WriteLine("Hayvan Sesi!");
        }
        private void animalSound2()
        {
            Console.WriteLine("Hayvan Sesi!!!!");
        }
    }
}
