using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class SettingsValues : List<SettingsValue>
    {

        public SettingsValues()
        {
            // Set Defaul Settings

            // Values
            SettingsValue UE4LocalizationPath = new SettingsValue("Paths", "UE4LocalizationPath", new DirectoryInfo(@"c:\\"));
            SettingsValue UE4MainPoFile = new SettingsValue("Paths", "UE4MainPoFile", new FileInfo(@"c:\\"));
            SettingsValue LocalizationCSV = new SettingsValue("Paths", "LocalizationCSV", new FileInfo(@"c:\\"));
            
            // Add Values
            this.Add(UE4LocalizationPath);
            this.Add(UE4MainPoFile);
            this.Add(LocalizationCSV);
        }

        /// <summary>
        /// Get computer LAN address like 192.168.1.3
        /// </summary>
        /// <returns></returns>
        private string GetComputer_LanIP()
        {
            string strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            foreach (IPAddress ipAddress in ipEntry.AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    return ipAddress.ToString();
                }
            }

            return "-";
        }

    }
}
