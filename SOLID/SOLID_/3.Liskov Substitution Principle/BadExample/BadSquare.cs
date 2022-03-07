using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._3.LSP
{
    public  class BadSquare: BadRetangle
    {
        int _lenght;
        public override int Lenght { get => _lenght; set => _lenght = value; }


        int _width;
        public override int Width { get => _width; set => _width = value; }
    }
}
