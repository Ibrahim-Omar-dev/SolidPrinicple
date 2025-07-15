using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principle.OCP.validation
{
    class VipCutomerType : IDisCountStrategy
    {
        public double GetDisCount() => 0.3;
    }
}
