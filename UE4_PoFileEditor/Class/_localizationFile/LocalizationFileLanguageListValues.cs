using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class LocalizationFileLanguageListValues
    {
        public string Key { get; set; }
        public List<LocalizationFileLanguageValue> ListValues { get; set; }
        public bool Valid { get; set; }

        public LocalizationFileLanguageListValues (string data, int KeyCell, List<LanguageCell> Languages, string SplitChar = "\t")
        {
            ListValues = new List<LocalizationFileLanguageValue>();
            Valid = false; 

            string[] DataValues = data.Split(new[] { SplitChar }, StringSplitOptions.None);
            foreach (LanguageCell Language in Languages)
            {
                if (DataValues.Length >= KeyCell && DataValues[KeyCell] != "")
                {
                    LocalizationFileLanguageValue Newvalue = new LocalizationFileLanguageValue();
                    Newvalue.Key = DataValues[KeyCell].Replace(",","");
                    Key = Newvalue.Key;
                    Valid = true;

                    if (DataValues.Length >= Language.Cell)
                    {
                        Newvalue.Value = DataValues[Language.Cell];
                        Newvalue.CultureInfo = new CultureInfo(Language.Language);
                    }

                    ListValues.Add(Newvalue);
                }
            }
        }

        public string GetValueFromLanguage (CultureInfo Language)
        {
            string ReturnString = "--1";
            foreach (LocalizationFileLanguageValue item in ListValues)
            {
                if (item.CultureInfo.Name == Language.Name)
                    return item.Value;
            }

            return ReturnString;
        }
    }
}
