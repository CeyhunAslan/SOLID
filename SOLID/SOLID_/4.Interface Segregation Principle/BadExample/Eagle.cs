using SOLID_._4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._4.ISP.BadExample
{
    public class Eagle : IBird
    {
        //Kartalların yüzmediği için burada da  prensibe aykırı haraket ettik
        public string Fly()
        {
            return "Kartalar uçabilirler";
        }

        public string Swim()
        {
            return "Kartallar yüzemezler";
        }

        public string Walk()
        {
            return "Kartalar yürüyebilirler;";
        }
    }
}
