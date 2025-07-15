using SOLID_Principle.DIP.DIP_Respected;
using SOLID_Principle.DIP.Violation_of_DIP;
using SOLID_Principle.ISP.ISP_Respected;
using SOLID_Principle.LSP.LSP_Respected;
using SOLID_Principle.OCP;
using SOLID_Principle.OCP.validation;
using OldPrinter = SOLID_Principle.ISP.ISP_Respected.OldPrinter;
using PizzaCutterArm = SOLID_Principle.DIP.DIP_Respected.PizzaCutterArm;

namespace SOLID_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OCP
            double totalAmount = 1000;
            Invoice2 invoice2 = new Invoice2(new RegularCustomerType());
            Console.WriteLine($"RegularCustomerType");
            invoice2.GetFinalAmmount(totalAmount);

            Invoice2 invoice3 = new Invoice2(new PremiumCutomerType());
            Console.WriteLine($"PremiumCutomerType");
            invoice3.GetFinalAmmount(totalAmount);

            Invoice2 invoice4 = new Invoice2(new VipCutomerType());
            Console.WriteLine($"VipCutomerType");
            invoice4.GetFinalAmmount(totalAmount);

            Invoice2 invoice5 = new Invoice2(new PlatinumCustomerType());
            Console.WriteLine($"PlatinumCutomerType");
            invoice5.GetFinalAmmount(totalAmount);
            Console.WriteLine("====================================================");
            #endregion
            #region LSP
            var paymentService = new PaymentService();

            IPayment bankPayment = new BankTransferPayment();
            paymentService.ExecutePayment(bankPayment);

            var ccPayment = new CreditCardPayment();
            paymentService.ExecutePayment(ccPayment);
            Console.WriteLine("====================================================");

            #endregion
            #region ISP
            IPrintable modernPrinter = new ModerPrinter();
            IScannable moderScan=new ModerPrinter();
            IFaxable moderFax=new ModerPrinter();
            modernPrinter.Print();
            moderScan.Scan();
            moderFax.Fax();
            Console.WriteLine("--Old--");
            IPrintable oldPrinter = new OldPrinter();
            oldPrinter.Print();
            Console.WriteLine("==================================");
            #endregion
            #region DIP
            var robot1 = new PizzaCutterRobot1(new PizzaCutterArm());
            robot1.CutPizza();
            var robot2 = new PizzaCutterRobot1(new Knife());
            robot2.CutPizza();
            #endregion
            Console.ReadKey();
        }
    }
}
