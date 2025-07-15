namespace SOLID_Principle.LSP.LSP_Respected
{
    class CreditCardPayment: IPayment,ICardValidatable
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment.");
        }
        public void ValidateCardInfo()
        {
            Console.WriteLine("Validating credit card info.");
        }
    }
}
