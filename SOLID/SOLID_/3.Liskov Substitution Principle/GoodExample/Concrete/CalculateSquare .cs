using SOLID_._3.LSP.GoodExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._3.LSP.GoodExample.Concrete
{
    public class CalculateSquare : Calculate<Square>
    {
        public override int CalculateArea(Square entity)
        {
            return entity.Edge * entity.Edge;
        }
    }
}
