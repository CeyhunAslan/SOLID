using SOLID_._4.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._4.ISP.GoodExample
{
    public class Chicken : IWalk
    {
        public string Walk()
        {
            return "Tavuklar yürüyebilirler";
        }
    }
}
