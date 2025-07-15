using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP
{
    class Invoice
    {
        public double GetDisCount(string customerType)
        {
            if(customerType == "Regular")
            {
                return 0.1; 
            }
            else if (customerType == "Premium")
            {
                return 0.2;
            }
            else if (customerType == "VIP")
            {
                return 0.3;            }
            else
            {
                return 0.0; 
            }
        }
    }
}
