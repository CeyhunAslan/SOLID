using SOLID_.Additional._2.Yangi.GoodExample.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_.Additional._2.Yangi.GoodExample
{
    public class Concrete : ILessons
    {
        public string History()
        {
            return "Tarih Dersi";
        }

        public string Liberal_Arts()
        {
            return "Sosyal Bilgiler Dersi";
        }

        public string Maths()
        {
            return "Matematik Dersleri";
        }

        public string Science()
        {
            return "Fen Bilimleri Dersi";
        }
    }
}
