using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class LocalizationFile 
    {
        public List<LocalizationFileLanguageListValues> LanguageValues { get; set; }
        public List<LanguageCell> Languages = new List<LanguageCell>();
        public int KeyCell = 2;

        public LocalizationFile(FileInfo Path, List<LanguageCell> Languages, int KeyCell)
        {
            this.LanguageValues = new List<LocalizationFileLanguageListValues>();
            this.Languages = Languages;
            this.KeyCell = KeyCell;

            if (Path.Exists)
            {
                LoadLocalizationFile(Path, "\n");
            }
        }

        private void LoadLocalizationFile(FileInfo Path, string SplitChar)
        {
            string Data = File.ReadAllText(Path.FullName);
            string[] DataValues = Data.Split(new[] { SplitChar }, StringSplitOptions.None);
            foreach (var Values in DataValues)
            {
                LocalizationFileLanguageListValues NewList = new LocalizationFileLanguageListValues(Values, KeyCell, Languages);
                if(NewList.Valid)
                    LanguageValues.Add(NewList);
            }
        }
    }
}
