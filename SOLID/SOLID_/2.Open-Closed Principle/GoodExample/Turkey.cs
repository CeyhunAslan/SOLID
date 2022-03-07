using SOLID_._2.OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._2.OCP.GoodExample
{
    internal class Turkey : GoodMeatShop
    {
        public override double GetTotalPrice(double amount)
        {
            return 2 * 8.35;
        }
    }
}
