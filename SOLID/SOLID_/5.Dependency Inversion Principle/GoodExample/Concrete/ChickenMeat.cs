using SOLID_._5.DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._5.DIP.GoodExample.Concrete
{
    public class ChickenMeat : IRecipes
    {
        public string GetCooking()
        {
            return "Tavuk ızagara tafileri..!";
        }
    }
}
