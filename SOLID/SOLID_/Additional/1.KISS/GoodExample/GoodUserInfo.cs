using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLID_.Additional._1.KISS.GoodExample
{
    public class GoodUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Pasword { get; set; }



        public void Eraser(GroupBox groupBox)
        {
            foreach (Control item in groupBox.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
            }
        }
    }
}
