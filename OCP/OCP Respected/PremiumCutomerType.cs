namespace SOLID_Principle.OCP.validation
{
    class PremiumCutomerType: IDisCountStrategy
    {
        public double GetDisCount() => 0.2;
    }
}
