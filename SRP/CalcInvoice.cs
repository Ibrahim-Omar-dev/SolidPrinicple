
namespace SOLID_Principle.Single_Responsibility
{
    public class CalcInvoice
    {
        public double Amount { get; set; }
        public double CalculateTotalWithTax()
        {
            return Amount * 1.5;
        }
    }
}
