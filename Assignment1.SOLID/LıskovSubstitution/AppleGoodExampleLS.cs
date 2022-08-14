using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.LıskovSubstitution
{
    public abstract class AppleGoodExampleLS
    {
        public abstract string GetColor();
    }
    public class AppleGood : AppleGoodExampleLS
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeGood : AppleGoodExampleLS
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
