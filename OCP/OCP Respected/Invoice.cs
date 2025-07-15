using SOLID_Principle.OCP.validation;

namespace SOLID_Principle.OCP
{
    class Invoice2

    {
        private readonly IDisCountStrategy _disCountStrategy;
        public Invoice2(IDisCountStrategy disCountStrategy)
        {
            _disCountStrategy = disCountStrategy;
        }
        public void GetFinalAmmount(double Amount)
        {
            double getDisCount = _disCountStrategy.GetDisCount();
            Console.WriteLine($"total Amount {Amount - (Amount * getDisCount)} after get discount {getDisCount}");
        }
    }
}
