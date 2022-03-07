using SOLID_._4.ISP.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._4.ISP.GoodExample
{
    public class Duck : IWalk, IFly, ISwim
    {
        public string Fly()
        {
            return "Ördekler uçabilir";
        }

        public string Swim()
        {
            return "Ördekler yüzebilir";
        }

        public string Walk()
        {
            return "Ördekler yürüyebilir";
        }
    }
}
