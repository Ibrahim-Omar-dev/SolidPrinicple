namespace SOLID_Principle.DIP.Violation_of_DIP
{
    // This class violates the Dependency Inversion Principle (DIP)
    // because it directly depends on a concrete implementation of PizzaCutterArm.
    class PizzaCutterRobot
    {
        private readonly PizzaCutterArm _pizzaCutterArm = new PizzaCutterArm();
        public void CutPizza()
        {
            _pizzaCutterArm.CutPizza();
        }
    }
}
