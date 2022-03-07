using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID_.Additional._1.KISS.GoodExample
{
    public class GoodLogin
    {
        GroupBox groupBox;
        public string Login()
        {
            
            GoodUserInfo goodUserInfo = new GoodUserInfo();

            goodUserInfo.UserName = "Textbox'dan Gelen Değer";
            goodUserInfo.FirstName = "Textbox'dan Gelen Değer";
            goodUserInfo.LastName = "Textbox'dan Gelen Değer";
            goodUserInfo.Pasword = "Textbox'dan Gelen Değer";

            goodUserInfo.Eraser(groupBox);
            //Böylelikle hem basit bir method kullanarak anlaşılır bir çözüm kullanmış oldum hemde kod kalabalığının önüne geçtim 
            return "Naşarıyla Giriş Yapılmıştır.";
        }

    }
}
