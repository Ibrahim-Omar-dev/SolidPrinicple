namespace SOLID_Principle.LSP.Violation_of_LSP
{
    public class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing generic payment.");
        }

        public virtual void ValidateCardInfo()
        {
            Console.WriteLine("Validating card info.");
        }
    }
}
