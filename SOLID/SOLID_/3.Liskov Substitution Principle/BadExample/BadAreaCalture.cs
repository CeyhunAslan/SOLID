using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._3.LSP
{
    public class BadAreaCalture
    {
        public static int CalculateArea(BadRetangle badRetangle)
        {
            return badRetangle.Width * badRetangle.Lenght;
        }

        public static int CalculateArea(BadSquare badSquare)
        {
            return badSquare.Width * badSquare.Lenght;
        }
    }
}
