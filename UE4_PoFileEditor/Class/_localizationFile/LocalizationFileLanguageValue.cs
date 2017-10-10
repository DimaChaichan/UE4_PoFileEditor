using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class LocalizationFileLanguageValue
    {
        public string Key { get; set; }
        public string SourceValue { get; set; }
        public string SourceLocation { get; set; }
        public string Comment { get; set; }
        public string Value { get; set; }
        public CultureInfo CultureInfo { get; set; }
        public int Cell { get; set; }

    }
}
