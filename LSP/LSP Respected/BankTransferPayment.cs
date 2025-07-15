namespace SOLID_Principle.LSP.LSP_Respected
{
    class BankTransferPayment: IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing bank transfer payment.");
        }
    }
}
