using SOLID_._4.ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._4.ISP.BadExample
{
    public class Duck : IBird
    {
        //Prensibe ayrıkı hareket etmediğimiz Duck.cs sınıfı
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
