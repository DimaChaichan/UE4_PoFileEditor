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
        public string SourceValue { get; set; }
        public string SourceLocation { get; set; }
        public List<LocalizationFileLanguageValue> ListValues { get; set; }
        public bool Valid { get; set; }

        public LocalizationFileLanguageListValues (string data, int KeyCell, int SourceValueCell , int SourceLocationCell, List<LanguageCell> Languages, string SplitChar = "\t")
        {
            ListValues = new List<LocalizationFileLanguageValue>();
            Valid = false; 

            string[] DataValues = data.Split(new[] { SplitChar }, StringSplitOptions.None);
            foreach (LanguageCell Language in Languages)
            {
                if ((DataValues.Length - 1) >= KeyCell && DataValues[KeyCell] != "")
                {
                    LocalizationFileLanguageValue Newvalue = new LocalizationFileLanguageValue();
                    Newvalue.Key = DataValues[KeyCell].Replace(",","");
                    Newvalue.SourceLocation = DataValues[SourceLocationCell].Replace(",", "");
                    Newvalue.SourceValue = DataValues[SourceValueCell].Replace(",", "");

                    Key = Newvalue.Key;
                    SourceValue = Newvalue.SourceValue;
                    SourceLocation = Newvalue.SourceLocation;
                    Valid = true;

                    if ((DataValues.Length - 1) >= Language.Cell)
                    {
                        Newvalue.Value = DataValues[Language.Cell];
                        Newvalue.CultureInfo = new CultureInfo(Language.Language);
                    }

                    ListValues.Add(Newvalue);
                }
            }
        }

        public LocalizationFileLanguageListValues(PoFileValues PoFileValue)
        {
            ListValues = new List<LocalizationFileLanguageValue>();
            Valid = false;

            if (PoFileValue.valid)
            {
                this.Key = PoFileValue.Key;
                this.SourceValue = PoFileValue.msgid;
                this.SourceLocation = PoFileValue.SourceLocation;

                this.Valid = true;
            }
            else
                this.Valid = false;
        }

        public LocalizationFileLanguageListValues(PoFileValues PoFileValue, CultureInfo Language, int Cell)
        {
            ListValues = new List<LocalizationFileLanguageValue>();
            Valid = false;

            if (PoFileValue.valid)
            {
                this.Key = PoFileValue.Key;
                LocalizationFileLanguageValue LanguageValue = new LocalizationFileLanguageValue();
                LanguageValue.Key = this.Key;
                LanguageValue.SourceValue = PoFileValue.msgid;
                LanguageValue.Value = PoFileValue.msgstr;
                LanguageValue.SourceLocation = PoFileValue.SourceLocation;
                LanguageValue.Comment = PoFileValue.Comment;
                LanguageValue.CultureInfo = Language;
                LanguageValue.Cell = Cell;
                ListValues.Add(LanguageValue);
                this.Valid = true;
            }
            else
                this.Valid = false;
        }

        public string GetValueFromLanguage (CultureInfo Language)
        {
            string ReturnString = "--1";
            foreach (LocalizationFileLanguageValue item in ListValues)
            {
                if (item.CultureInfo != null)
                {
                    if (item.CultureInfo.Name == Language.Name)
                        return item.Value;
                }
                else
                    return ReturnString;
            }

            return ReturnString;
        }
    }
}
