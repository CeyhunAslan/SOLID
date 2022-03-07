using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._5.DIP.BadExample
{
    public class BadRestaurant
    {
        DuckMeat duckMeat = new DuckMeat();
        RedMeat redMeat = new RedMeat();

        public string GetMenu()
        {
            return $"{duckMeat.Duck()} \n {redMeat.KırmızıEt()} ";
        }
    }
}
