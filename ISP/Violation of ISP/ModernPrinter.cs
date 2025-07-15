namespace SOLID_Principle.ISP.Violation_of_ISP
{
    public class ModernPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printing...");
        }
        public void Scan(string document)
        {
            Console.WriteLine("Scaning...");
        }
        public void Fax(string document)
        {
            Console.WriteLine("Fax...");
        }
    }
}
