using SOLID_._1.SRP.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._1.SRP.Bad_Example
{
    public class BadEmployee
    {
        void CreateEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                #region Process 1: Çalışanın özlük bilgilerinin veri tabanına kayıt edilmesi
                stringBuilder.Append(employee.Id.ToString());
                stringBuilder.Append(employee.FirstName);
                stringBuilder.Append(employee.LastName);
                stringBuilder.Append(employee.HireDate.ToString());
                File.WriteAllText(@"C:\EmployeeData.txt", stringBuilder.ToString());
                #endregion

                #region  Process 2: Kayıt Log işlemleri
                stringBuilder = new StringBuilder();
                stringBuilder.Append("Kayıt Tarihi: ");
                stringBuilder.Append(DateTime.Now.ToString());
                stringBuilder.Append(employee.Id);
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
                #endregion
            }
            catch (Exception ex)
            {
                #region Process 3: Exception Log İşlemleri
                stringBuilder = new StringBuilder();
                stringBuilder.Append(ex.Message);
                stringBuilder.Append(DateTime.Now.ToString());
                File.WriteAllText(@"C:\Log.txt", stringBuilder.ToString());
                #endregion
            }
        }
    }
}
