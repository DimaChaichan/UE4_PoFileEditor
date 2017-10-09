using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class LanguageCell
    {
        public string Language { get; set; }
        public int Cell { get; set; }

        public LanguageCell (string Language, int Cell)
        {
            this.Language = Language;
            this.Cell = Cell;
        }
    }
}
