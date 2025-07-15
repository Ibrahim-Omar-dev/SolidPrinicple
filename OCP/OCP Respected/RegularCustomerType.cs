namespace SOLID_Principle.OCP.validation
{
    class RegularCustomerType : IDisCountStrategy
    {
        public double GetDisCount()=>0.1;
    }
}
