using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.OpenClosed
{
    public class AnimalGoodExampleOC
    {
        public virtual void Add(List<string> list)
        {
            list.Add("Dog");
        }
    }
    public class ExistingAnimal : AnimalGoodExampleOC
    {
        public override void Add(List<string> list)
        {
            //list.ExistingAnimal();
        }
    }

    public class AnotherAnimal : AnimalGoodExampleOC
    {
        public override void Add(List<string> list)
        {
            //list.AnotherAnimal();
        }
    }
}
