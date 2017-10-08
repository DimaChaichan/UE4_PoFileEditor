using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    class SettingsFileControl
    {
        #region Global Variables
        //***************************************************
        public string path { get; set; } // Path auf Inifile
        //***************************************************
        #endregion

        #region Load Kernel32
        //***************************************************
        [DllImport("kernel32")]
        private static extern int WritePrivateProfileString(string section,
          string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
          string key, string def, StringBuilder retVal,
          int size, string filePath);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileSection(string lpAppName, byte[] lpszReturnBuffer, int nSize, string lpFileName);
        //***************************************************
        #endregion

        /// <summary>
        /// Create a SettingController
        /// with Utilities
        /// </summary>
        public SettingsFileControl(string FilePath)
        {
            this.path = FilePath;
        }


        /// <summary>
        /// Get All Keys from a category
        /// </summary>
        /// <param name="category">From Aategory</param>
        /// <returns>string List all Keeys(string)</returns>
        public List<string> GetKeys(string category)
        {
            byte[] buffer = new byte[2048];
            GetPrivateProfileSection(category, buffer, 2048, path);
            String[] tmp = Encoding.ASCII.GetString(buffer).Trim('\0').Split('\0');

            List<string> result = new List<string>();

            if (tmp[0] != "")
            {
                foreach (String entry in tmp)
                {
                    result.Add(entry.Substring(0, entry.IndexOf("=")));
                }
            }

            return result;
        }

        /// <summary>
        /// Write Value to INI-File
        /// </summary>
        /// <param name="Section">Section in the INI-File</param>
        /// <param name="Key">Key in the INI-File</param>
        /// <param name="Value">Value for the Key</param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        /// <summary>
        /// Read Value from INI-File
        /// </summary>
        /// <param name="Section">Section in the INI-File</param>
        /// <param name="Key">Key in the INI-File</param>
        /// <returns>String of the Key Value</returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(9999); 
            int i = GetPrivateProfileString(Section, Key, "", temp, 9999, this.path);

            // When the Value is 0 write a new Key
            //if (i == 0)
            //    IniWriteValue(Section, Key, "");

            return temp.ToString();
        }

        /// <summary>
        /// Split a Spring to List<String> 
        /// </summary>
        /// <param name="value">to split String</param>
        /// <param name="tosplit">split string with char</param>
        /// <returns>string List from Value(string)</returns>
        public List<string> splitStringtoList(string value, Char tosplit)
        {
            List<string> newList = new List<string>(); 
            string[] values = value.Split(new Char[] { tosplit });
            foreach (string newValue in values)
            {
                newList.Add(newValue);
            }
            return newList;
        }


    }
}
