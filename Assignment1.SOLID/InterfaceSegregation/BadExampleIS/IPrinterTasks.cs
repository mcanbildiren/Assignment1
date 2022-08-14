using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.InterfaceSegregation.BadExampleIS
{
    public interface IPrinterTasks
    {
        // Interface Segregation: Bütün sorumlulukların farklı interface'lere dağıtılarak oluşturulmasıdır. Sınıflar miras alırken kullanmayacakları özellikleri almamış olurlar.
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);

    }
}
