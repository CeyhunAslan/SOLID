using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_.Additional._2.Yangi.BadExample.Interface
{
    public interface ILessons
    {
        string Liberal_Arts();
        string Science();
        string History();


        //Şimdilik matematik dersi vermiyor bu okul ama ben ileride maths dersi vericeğim için burada yaratıp Yangi! prensibine aykırı davrandım
        string Maths();


    }
}
