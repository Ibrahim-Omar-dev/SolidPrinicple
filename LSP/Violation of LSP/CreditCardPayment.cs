namespace SOLID_Principle.LSP.Violation_of_LSP
{
    public class CreditCardPayment : Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }

        public override void ValidateCardInfo()
        {
            Console.WriteLine("Validating credit card info.");
        }
    }
}
