using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.OOP.Abstraction
{
    internal class DogAbstraction : AnimalAbstraction
    {
        public override void animalSound()
        {
            Console.WriteLine("Köpek sesi: Hav! Hav!");
        }
    }
}
