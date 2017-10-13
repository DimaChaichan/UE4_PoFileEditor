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
        public int SourceCell = 4;
        public int SourceLocationCell = 5;

        public LocalizationFile()
        {
            this.LanguageValues = new List<LocalizationFileLanguageListValues>();
            this.Languages = new List<LanguageCell>();
            this.KeyCell = 0;
            this.SourceCell = 1;
            this.SourceLocationCell = 2;
        }

        public LocalizationFile(FileInfo Path, List<LanguageCell> Languages, int KeyCell, int SourceCell, int SourceLocationCell)
        {
            this.LanguageValues = new List<LocalizationFileLanguageListValues>();
            this.Languages = Languages;
            this.KeyCell = KeyCell;
            this.SourceCell = SourceCell;
            this.SourceLocationCell = SourceLocationCell;

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
                string ConvertValues = Values;
                if (ConvertValues != "")
                {
                    if (ConvertValues.Substring(ConvertValues.Length - 1) == "\r")
                        ConvertValues = ConvertValues.Remove(ConvertValues.Length - 1);
                }

                LocalizationFileLanguageListValues NewList = new LocalizationFileLanguageListValues(ConvertValues, KeyCell, SourceCell, SourceLocationCell, Languages);
                if(NewList.Valid)
                    LanguageValues.Add(NewList);
            }
        }

        public void AddPoFileSource(PoFile ToAddPofile)
        {
            foreach (PoFileValues Value in ToAddPofile.Values)
            {
                LocalizationFileLanguageListValues NewLanguageListValues = new LocalizationFileLanguageListValues(Value);
                LanguageValues.Add(NewLanguageListValues);
            }
        }

        public void AddPoFile (PoFile ToAddPofile, LanguageCell Language)
        {
            foreach (PoFileValues Value in ToAddPofile.Values)
            {
                CultureInfo NewcultureInfo = new CultureInfo(Language.Language);
                LocalizationFileLanguageListValues NewLanguageListValues = new LocalizationFileLanguageListValues(Value, NewcultureInfo, Language.Cell);
                LocalizationFileLanguageListValues TranslateValue = LanguageValues.Find(x => x.Key == NewLanguageListValues.Key);
                if (TranslateValue != null)
                {
                    foreach (var item in NewLanguageListValues.ListValues)
                    {

                        TranslateValue.ListValues.Add(item);
                    }
                }
            }
        }

        public void CombinePoFile (PoFile ToAddPofile, LanguageCell Language)
        {
            foreach (PoFileValues Value in ToAddPofile.Values)
            {
                CultureInfo NewcultureInfo = new CultureInfo(Language.Language);
                LocalizationFileLanguageListValues NewLanguageListValues = new LocalizationFileLanguageListValues(Value, NewcultureInfo, Language.Cell);
                LanguageValues.Add(NewLanguageListValues);
            }
        }

        public void SaveFile(FileInfo SaveFile)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(SaveFile.FullName))
            {
                foreach (LocalizationFileLanguageListValues item in LanguageValues)
                {
                    List<string> Savestring = new List<string>();
                    for (int i = 0; i < KeyCell + SourceCell + item.ListValues.Count + 150; i++)
                    {
                        Savestring.Add("XTempX");
                    }
                    Savestring[KeyCell] = item.Key;
                    Savestring[SourceCell] = item.SourceValue;
                    Savestring[SourceLocationCell] = item.SourceLocation;

                    int MaxCount = 0;
                    foreach (LocalizationFileLanguageValue ListValue in item.ListValues)
                    {
                        Savestring[ListValue.Cell] = ListValue.Value;

                        if (ListValue.Cell >= MaxCount)
                            MaxCount = ListValue.Cell;
                    }
                    if (KeyCell >= MaxCount)
                        MaxCount = KeyCell;
                    if (SourceCell >= MaxCount)
                        MaxCount = SourceCell;
                    if (SourceLocationCell >= MaxCount)
                        MaxCount = SourceLocationCell;

                    string WriteLine = "";
                    for (int i = 0; i <= MaxCount; i++)
                    {
                        string SaveValue = Savestring[i];
                        if (SaveValue == "XTempX")
                            SaveValue = "";

                        if (i == 0)
                            WriteLine = WriteLine + SaveValue;
                        else
                            WriteLine = WriteLine + "\t" + SaveValue;
                    }


                    WriteLine = WriteLine + "\t";
                    file.WriteLine(WriteLine);
                }
            }
        }
    }
}
