namespace Assignment1.SOLID.InterfaceSegregation.GoodExampleIS
{
    public class LaserJetPrinterGood : IPrinterTasksGood, IPrintDuplexTasks, IFaxTasks
    {
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }

        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }

        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
    }
}
