using SOLID_._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._5.DIP.GoodExample.Concrete
{
    public class RedMeat:IRecipes
    {
        public string GetCooking()
        {
            return "Kavurma";
        }

        public string Second()
        {
            return "Haşlama";
        }
    }
}
