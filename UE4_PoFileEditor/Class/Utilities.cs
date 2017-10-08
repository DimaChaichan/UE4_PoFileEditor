using System;
using System.Collections.Generic;
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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(CsvFile.FullName, true))
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

    }
}
