using SOLID_._2.OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._2.OCP.GoodExample
{
    public class RedMeat : GoodMeatShop
    {
        public override double GetTotalPrice(double amount)
        {
            return 12.55 * amount;
        }
    }
}
