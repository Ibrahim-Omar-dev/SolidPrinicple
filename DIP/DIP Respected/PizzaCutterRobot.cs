namespace SOLID_Principle.DIP.DIP_Respected
{
    class PizzaCutterRobot1
    {
        private readonly ICuttingTool _tool;
        public PizzaCutterRobot1(ICuttingTool tool)
        {
            _tool = tool;
        }
        public void CutPizza()
        {
            _tool.Cut();
        }
    }
}
