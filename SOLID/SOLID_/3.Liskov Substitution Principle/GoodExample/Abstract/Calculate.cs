using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._3.LSP.GoodExample
{
    public abstract class Calculate<TEntity>
    {
        public abstract int CalculateArea(TEntity entity);
    }
}
