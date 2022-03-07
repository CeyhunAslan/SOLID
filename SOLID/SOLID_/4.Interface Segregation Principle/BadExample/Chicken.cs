using SOLID_._4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._4.ISP.BadExample
{
    public class Chicken : IBird
    {//Tavuklar uçamadığından  ve yüzmediğinden bu methodu gereksiz yere kalıtığı için ISP'ye ters düştük.
        public string Fly()
        {
            return "Tavuklar uçamaz";
        }

        public string Swim()
        {
            return "Tavuklar yüzemez";
        }

        public string Walk()
        {
            return "Tavuklar yürüyebilirler";
        }
    }
}
