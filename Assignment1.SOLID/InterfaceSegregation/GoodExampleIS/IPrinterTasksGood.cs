using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.InterfaceSegregation.GoodExampleIS
{
    public interface IPrinterTasksGood
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    
    interface IFaxTasks
    {
        void Fax(string FaxContent);
    }

    interface IPrintDuplexTasks
    {
        void PrintDuplex(string PrintDuplexContent);
    }
}
