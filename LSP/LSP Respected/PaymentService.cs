namespace SOLID_Principle.LSP.LSP_Respected
{
    class PaymentService
    {
        public void ExecutePayment(IPayment payment)
        {
            payment.ProcessPayment();

            // If the payment type supports card validation, validate it
            if (payment is ICardValidatable cardPayment)
            {
                cardPayment.ValidateCardInfo();
            }
        }
    }
}
