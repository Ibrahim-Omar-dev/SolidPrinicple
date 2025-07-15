namespace SOLID_Principle.Single_Responsibility
{
    // this is bad practice as it violates the Single Responsibility Principle (SRP)
    public class Invoice
    {
        public string CustomerName { get; set; }
        public double Amount { get; set; }
        public double CalculateTotalWithTax()
        {
            return Amount * 1.5;
        }
        public void PrintInvoice()
        {
            Console.WriteLine($"Customer: {CustomerName}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Total with Tax: {CalculateTotalWithTax()}");
        }
        public void SaveToDatabase()
        {
            // Code to save invoice to database
            Console.WriteLine("Invoice saved to database.");
        }
    }
}
