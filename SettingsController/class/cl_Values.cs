using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
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
            SettingsValue KeyCell = new SettingsValue("Cells", "KeyCell", 0);
            SettingsValue SourceCell = new SettingsValue("Cells", "SourceCell", 1);
            SettingsValue SourceLocationCell = new SettingsValue("Cells", "SourceLocationCell", 2);


            List<cl_ListKeyBool> languageList = new List<cl_ListKeyBool>();
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                if (ci.Name != "")
                    languageList.Add(new cl_ListKeyBool(ci.Name, false));
            }
            SettingsValue LanguageList = new SettingsValue("LanguageList", "LanguageListID", languageList);

            List<string> PresetsFilesList = new List<string>();
            PresetsFilesList.Add("default.ini");
            SettingsValue PresetsFiles = new SettingsValue("Preset", "PresetsFiles", PresetsFilesList);

            List<cl_ListKeyInt> languageListCell = new List<cl_ListKeyInt>();
            SettingsValue LanguageCellList = new SettingsValue("LanguageListCell", "LanguageListCellID", languageListCell);

            // Add Values
            this.Add(UE4LocalizationPath);
            this.Add(UE4MainPoFile);
            this.Add(LocalizationCSV);
            this.Add(PresetsFiles);

            this.Add(LanguageCellList);
            this.Add(LanguageList);

            this.Add(KeyCell);
            this.Add(SourceCell);
            this.Add(SourceLocationCell);
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
