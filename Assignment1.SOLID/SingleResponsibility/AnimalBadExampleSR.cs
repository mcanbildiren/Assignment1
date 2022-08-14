using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.SingleResponsibility
{
    // Single Responsibility: Bir sınıfın tek bir sorumluluğa sahip olmasıdır. Bir sınıfta ne kadar fazla sorumluluk varsa, kodda değişim yapmak o kadar zor olur.. Örnekte olduğu gibi hem listeye ekleme hem de loglama işi tek bir sınıf tarafından yapılamamalıdır. 
    internal class AnimalBadExampleSR
    {
        void Add(List<string> list)
        {
            try
            {
                list.Add("Dog");
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\Error.txt", ex.ToString());
            }
        }
    }
}
