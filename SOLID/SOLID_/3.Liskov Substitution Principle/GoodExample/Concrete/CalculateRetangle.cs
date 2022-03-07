using SOLID_._3.LSP.GoodExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._3.LSP.GoodExample.Concrete
{
    internal class CalculateRetangle : Calculate<Retangle>
    {
        public override int CalculateArea(Retangle entity)
        {
            return entity.Edge * entity.Lenght;
        }
    }
}
