using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.OpenClosed
{
    // Open/Closed: Bir sınıfa yeni özellikler eklenirken özelliklerini korumalı ve davranışını değiştirmemelidir. Örnekte sadece 2 tipte hayvan kaydedilebilmektedir. Eğer yeni bir tip eklenmek istenirse ayrı bir if statement yazılması gerekir. Bu durum open closed prensibine terstir.
    internal class AnimalBadExampleOC
    {
        int Type;

        void Add(List<string> list)
        {
            if (Type == 0)
            {
                list.Add("Dog");
            }
            else
            {
                //List.AddExistingAnimal("Cat");
            }
        }
    }
}
