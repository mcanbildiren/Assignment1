using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.DependencyInversion
{
    // Dependency Inversion: Üst seviye sınıflar alt seviye sınıflara bağlı olmamalıdır. Her ikisi de soyut kavramlar kullanılarak yönetilmelidir.
    public class BadExampleDI
    {
        internal void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
        }
    }

    public class Customer
    {
        BadExampleDI logger = new BadExampleDI();

        public void Add(List<string> list)
        {
            try
            {
                list.Add("txt loglandı!");
            }
            catch (Exception error)
            {
                logger.Handle(error.ToString());
            }
        }
    }
}
