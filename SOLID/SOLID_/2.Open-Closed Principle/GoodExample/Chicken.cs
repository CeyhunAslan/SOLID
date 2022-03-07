using SOLID_._2.OCP.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._2.OCP.GoodExample
{
    public class Chicken : GoodMeatShop
    {
        public override double GetTotalPrice(double amount)
        {
            return 4.25 * amount;
        }
    }
}
