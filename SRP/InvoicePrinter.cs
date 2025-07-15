namespace SOLID_Principle.Single_Responsibility
{
    public class InvoicePrinter
    {
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public void PrintInvoice(CalcInvoice calcInvoice)
        {
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Total with Tax: {calcInvoice.CalculateTotalWithTax()}");
        }
    }
}
