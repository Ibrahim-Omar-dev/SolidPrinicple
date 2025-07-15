namespace SOLID_Principle.ISP.ISP_Respected
{
    class ModerPrinter:IPrintable, IScannable, IFaxable
    {
        
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning...");
        }
        public void Fax()
        {
            Console.WriteLine("Fax...");
        }
    }
}
