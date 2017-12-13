using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    static public class Utilities
    {
        /// <summary>
        /// Convert Po-File To Csv-File
        /// </summary>
        /// <param name="ToConvertPoFile">Pofile structur</param>
        /// <param name="CsvFile">To Save CSV-File</param>
        static public void ConvertAndSavePoToCsv(PoFile ToConvertPoFile, FileInfo CsvFile)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(CsvFile.FullName))
            {
                foreach (PoFileValues Value in ToConvertPoFile.Values)
                {
                    file.WriteLine(Value.ExportCsvString());
                }
            }
        }

        static public PoFile ConvertCsvToPoFile(FileInfo CsvFile)
        {
            PoFile RetrunPoFile = new PoFile();
            if(CsvFile.Exists)
            {
                string AllData = File.ReadAllText(CsvFile.FullName);
                string[] DataValues = AllData.Split(new[] { "\n" }, StringSplitOptions.None);
                foreach (string Data in DataValues)
                {
                    PoFileValues poFileValue = new PoFileValues(Data, true);
                    if (poFileValue.valid)
                        RetrunPoFile.Values.Add(poFileValue);
                }
            }
            return RetrunPoFile;
        }

        static public PoFile CreatePofileFromLocalizationCSV (LocalizationFile localizationFile, string Language)
        {
            PoFile RetrunPoFile = new PoFile();
            CultureInfo LanguageInfo = new CultureInfo(Language);
            foreach (LocalizationFileLanguageListValues Values in localizationFile.LanguageValues)
            {
                string NewValue = Values.GetValueFromLanguage(LanguageInfo);
                if(NewValue != "--1")
                {
                    PoFileValues poFileValue = new PoFileValues();
                    poFileValue.Key = Values.Key;
                    poFileValue.msgctxt = "\"," + Values.Key + "\"";
                    if (poFileValue.msgctxt.Substring(0, 1) == "\"")
                        poFileValue.msgctxt = poFileValue.msgctxt.Substring(1, poFileValue.msgctxt.Length - 1);

                    if (poFileValue.msgctxt.Substring(poFileValue.msgctxt.Length - 1) == "\"")
                        poFileValue.msgctxt = poFileValue.msgctxt.Remove(poFileValue.msgctxt.Length - 1);

                    poFileValue.msgstr = "\"" + NewValue + "\"";
                    if (poFileValue.msgstr.Substring(0, 1) == "\"")
                        poFileValue.msgstr = poFileValue.msgstr.Substring(1, poFileValue.msgstr.Length - 1);

                    if (poFileValue.msgstr.Substring(poFileValue.msgstr.Length - 1) == "\"")
                        poFileValue.msgstr = poFileValue.msgstr.Remove(poFileValue.msgstr.Length - 1);

                    poFileValue.SourceLocation = Values.SourceLocation;
                    poFileValue.msgid = Values.SourceValue;

                    RetrunPoFile.Values.Add(poFileValue);
                }
            }

            return RetrunPoFile;
        }

        static public PoFile CombinePoFiles (PoFile SourceFile, PoFile ToCombine)
        {
            PoFile RetrunPoFile = new PoFile();
            foreach (PoFileValues Values in SourceFile.Values)
            {
                PoFileValues FindValue = ToCombine.Values.Find(x => x.Key == Values.Key);
                if (FindValue != null)
                {
                    Values.msgstr = FindValue.msgstr;
                }
                RetrunPoFile.Values.Add(Values);
            }

            return RetrunPoFile;
        }

        static public LocalizationFile CombineLocalizationFile (LocalizationFile File_01, LocalizationFile File_02)
        {
            LocalizationFile NewLocalizationFileInfo = new LocalizationFile();
            NewLocalizationFileInfo.KeyCell = File_01.KeyCell;
            NewLocalizationFileInfo.SourceLocationCell = File_01.SourceLocationCell;
            NewLocalizationFileInfo.SourceCell = File_01.SourceCell;
            NewLocalizationFileInfo.Languages = File_01.Languages;

            foreach (LocalizationFileLanguageListValues item in File_01.LanguageValues)
            {
                if (item.Key == "4578CBBF4D3D4C6FEAAA21B824BDFE99")
                    Console.WriteLine("");

                string CheckValue = item.SourceValue.Trim();
                LocalizationFileLanguageListValues FindValue = File_02.LanguageValues.Find(x => x.SourceValue.Trim() == CheckValue);
                if (FindValue != null)
                {


                    foreach (var Value_source in item.ListValues)
                    {
                        foreach (var Value_combine in FindValue.ListValues)
                        {
                            if (Value_source.CultureInfo.DisplayName == Value_combine.CultureInfo.DisplayName)
                            {
                                if (Value_source.Value == "" && Value_combine.Value != "" && Value_source.SourceValue != Value_combine.Value)
                                {
                                    Value_source.Value = Value_combine.Value;
                                }
                                break;
                            }
                        }
                    }

                    NewLocalizationFileInfo.LanguageValues.Add(item);
                }
                else
                {
                    NewLocalizationFileInfo.LanguageValues.Add(item);
                }
            }


            return NewLocalizationFileInfo;
        }
    }
}
