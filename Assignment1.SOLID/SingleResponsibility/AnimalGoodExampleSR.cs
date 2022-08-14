using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.SingleResponsibility
{
    internal class AnimalGoodExampleSR
    {
        private FileLogger logger = new FileLogger();
        void Add(List<string> list)
        {
            try
            {
                list.Add("Dog");
            }
            catch (Exception ex)
            {
                logger.Handle(ex.ToString());
            }
        }
    }
    class FileLogger
    {
        internal void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
        }
    }
}
