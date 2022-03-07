using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._2.OCP.Bad_Example
{
    public enum Food { chicken = 1, RedMeat = 2, turkey = 3  }
    public class BadMeatShop
    {
        public double GetTotalPrice(double amount, Food meatTypes)
        {
            double totalPrice = 0;

            if (meatTypes == Food.chicken)
            {
                totalPrice += amount * 4.25;
            }
            else if (meatTypes == Food.turkey)
            {
                totalPrice += amount * 8.35;
            }
            else if (meatTypes == Food.RedMeat)
            {
                totalPrice += amount * 12.55;
            }

            return totalPrice;
        }
    }
}
