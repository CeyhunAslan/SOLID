using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_.Additional._1.KISS.BadExample
{
    public class BadLogin
    {
        public string Login()
        { 
            BadUserInfo badUserInfo = new BadUserInfo();

            badUserInfo.UserName = "Textbox'dan Gelen Değer";
            badUserInfo.LastName = "Textbox'dan Gelen Değer";
            badUserInfo.FirstName = "Textbox'dan Gelen Değer";
            badUserInfo.Pasword = "Textbox'dan Gelen Değer";

            //Kullanıcının girdiği her texbox'i bu şekilde tek tek silicem kod kalabalığı ve karmaşık bir yapı yaratarak

            //"TextBox.Text" = string.Empty;
            //"TextBox.Text" = string.Empty;
            //"TextBox.Text" = string.Empty;
            //"TextBox.Text" = string.Empty;



            return "Başarıla Giriş yapıldı / textboxlar silindi";
        }

    }
}
