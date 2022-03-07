using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_._1.SRP.Good_Example
{
    public class GoodLogger
    {
        public void LogFile(string filePath, string Log)
        {
            File.WriteAllText(filePath, Log);
        }

        public string BuildLog(string logInformation)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Date: ");
            stringBuilder.Append(DateTime.Now.ToString());
            stringBuilder.Append("Log Info: ");
            stringBuilder.Append(logInformation);

            return stringBuilder.ToString();
        }
    }
}
