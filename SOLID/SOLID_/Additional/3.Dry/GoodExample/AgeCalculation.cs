using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_.Additional._3.Dry.BadExample
{
    public class AgeCalculation
    {
        public int Age(string DogumTarihi)
        {
            DogumTarihi = "05/07/2000";
            DateTime DogumYıl = Convert.ToDateTime(DogumTarihi);

            int Yas =  DogumYıl.Year - DateTime.Now.Year;


            return Yas;
        }

        //Bu örnekte olduğu gibi istediğim yerde çağırıp kullanabileceğim bir yaş fonksiyonum var tekrar tekara yaş hesaplama yapmak yerine tek methodu çağırıp kod tekaraını önelemiş olurum 


        //eğer methodumu oluşturmasydım yas hesaplama gereken her yer aşağıdakı kodu tterar etmek zorunda kalırdım..


        //string DogumTarihi = "05/07/2000";//Kulanıcının texbox'a girdiği değer 
        //DateTime DogumYıl = Convert.ToDateTime(DogumTarihi);

        //int Yas = DogumYıl.Year - DateTime.Now.Year;
    }
}

