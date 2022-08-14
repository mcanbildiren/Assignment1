using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.SOLID.DependencyInversion
{
    class GoodExampleDI
    {
        ILogger logger;
        GoodExampleDI(ILogger logger)
        {
            this.logger = logger;
        }

        void Add(List<string> list)
        {
            try
            {
                list.Add("email loglandı!");
            }
            catch (Exception error)
            {
                logger.Handle(error.ToString());
            }
        }
    }
    class EmailLogger : ILogger
    {
        void Handle(string error)
        {
            File.WriteAllText(@"C:\Error.txt", error);
        }

        void ILogger.Handle(string error)
        {
            throw new NotImplementedException();
        }
    }

    interface ILogger
    {
        void Handle(string error);
    }

}
