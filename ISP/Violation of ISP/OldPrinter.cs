namespace SOLID_Principle.ISP.Violation_of_ISP
{
    //the problem here that old printer does not support scanning and faxing
    // so it violates the ISP principle by forcing the implementation of methods
    // that are not applicable to it.
    public class OldPrinter : IPrinter
    {
        public void Fax(string document)
        {
            throw new NotImplementedException();
        }

        public void Print(string document)
        {
            Console.WriteLine("Printing...");
        }

        public void Scan(string document)
        {
            throw new NotImplementedException();
        }
    }
}
