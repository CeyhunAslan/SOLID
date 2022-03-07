using SOLID_._1.SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._1.SRP.Good_Example
{
    public class GoodInsertEmployee
    {
        public GoodLogger goodLogger;

        public GoodInsertEmployee()
        {
            goodLogger = new GoodLogger();
        }

        string log;

        public void CreateEmployee(Employee employee)
        {
            StringBuilder stringBuilder = new StringBuilder();

            try
            {
                stringBuilder.Append(employee.Id.ToString());
                stringBuilder.Append(employee.FirstName);
                stringBuilder.Append(employee.LastName);
                stringBuilder.Append(employee.HireDate.ToString());

                log = goodLogger.BuildLog(stringBuilder.ToString());

                goodLogger.LogFile(@"C:\Log.txt", log);
            }
            catch (Exception ex)
            {
                log = goodLogger.BuildLog(ex.Message);
                goodLogger.LogFile(@"C:\Log.txt", log);
            }
        }

    }
}
