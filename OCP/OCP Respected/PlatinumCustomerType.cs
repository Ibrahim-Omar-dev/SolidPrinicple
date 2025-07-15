namespace SOLID_Principle.OCP.validation
{
    class PlatinumCustomerType: IDisCountStrategy
    {
        public double GetDisCount() => 0.4;
    }
}
