using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class DataViewerValue
    {
        public string Key { get; set; }
        public string SourceLocation { get; set; }
        public string SourceValue { get; set; }
        public List<DataViewerLanguageValue> LanguageValues { get; set; }

        public DataViewerValue(string Key, string SourceValue , string SourceLocation = "")
        {
            this.Key = Key;
            this.SourceLocation = SourceLocation;
            this.SourceValue = SourceValue;

            LanguageValues = new List<DataViewerLanguageValue>();
        }


        public class DataViewerLanguageValue
        {
            public CultureInfo cultureInfo { get; set; }
            public string Value { get; set; }
        }
    }
}
