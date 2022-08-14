using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.LıskovSubstitution
{
    // Lıskov Substitution: Kodda herhangi bir değişiklik yapılmadan alt sınıfların, üst sınıfların yerine kullanılabilmesidir.
    public class AppleBadExampleLS
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : AppleBadExampleLS
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
