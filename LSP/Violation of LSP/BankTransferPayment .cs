using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.LSP.Violation_of_LSP
{
    public class BankTransferPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing bank transfer.");
        }

        // ❌ Violation: Not applicable to Bank Transfer, but still must override
        public override void ValidateCardInfo()
        {
            throw new NotSupportedException("Bank transfer does not require card validation.");
        }
    }
}
