using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class PoFileValues
    {
        // Porperties
        public string Key { get; set; }
        public string SourceLocation { get; set; }
        public string Comment { get; set; }
        public string msgctxt { get; set; }
        public string msgid { get; set; }
        public string msgstr { get; set; }
        public bool valid { get; set; }

        public PoFileValues()
        {
             Key = "";
             SourceLocation = "";
             Comment = "";
             msgctxt = "";
             msgid = "";
             msgstr = "";
             valid = true;
        }

        // Create 
        public PoFileValues(string Data , bool CsvData = false)
        {
            valid = false;

            if (CsvData == false)
            {
                List<string> SplitData = new List<string> (Data.Split(new[] { "\n" }, StringSplitOptions.None));
                for (int i = SplitData.Count - 1; i >= 0; i--)
                {
                    if (SplitData[i] == "")
                        SplitData.RemoveAt(i);
                }


                if (SplitData.Count > 5 && SplitData[0].IndexOf("Key:") != -1)
                {
                    Key = SplitData[0].Replace("#. Key:", "").Replace("\t", "").Replace("\r", "");
                    SourceLocation = SplitData[1].Replace("#. SourceLocation:", "").Replace("\t", "").Replace("\r", "");
                    Comment = SplitData[2].Replace("#: ", "").Replace("\t", "").Replace("\r", "");

                    msgctxt = SplitData[3].Replace("msgctxt ", "").Replace("\t", "").Replace("\r", "");
                    if (msgctxt.Substring(0, 1) == "\"")
                        msgctxt = msgctxt.Substring(1, msgctxt.Length - 1);

                    if (msgctxt.Substring(msgctxt.Length - 1) == "\"")
                        msgctxt = msgctxt.Remove(msgctxt.Length - 1);


                    msgid = SplitData[4].Replace("msgid ", "").Replace("\t", "").Replace("\r", "");
                    if (msgid.Substring(0, 1) == "\"")
                        msgid = msgid.Substring(1, msgid.Length - 1);

                    if (msgid.Substring(msgid.Length - 1) == "\"")
                        msgid = msgid.Remove(msgid.Length - 1);


                    msgstr = SplitData[5].Replace("msgstr ", "").Replace("\t", "").Replace("\r", "");
                    if (msgstr.Substring(0, 1) == "\"")
                        msgstr = msgstr.Substring(1, msgstr.Length - 1);

                    if (msgstr.Substring(msgstr.Length - 1) == "\"")
                        msgstr = msgstr.Remove(msgstr.Length - 1);


                    valid = true;
                }
            }
            else
            {
                string[] SplitDataCsv = Data.Split(new[] { "\t" }, StringSplitOptions.None);
                if (SplitDataCsv.Length == 4)
                {
                    Key = SplitDataCsv[2].Replace(",","").Replace("\"", "");
                    string[] SourceKey = SplitDataCsv[3].Split(new[] { "SourceLocation:" }, StringSplitOptions.None);
                    if (SourceKey.Length > 1)
                    {
                        SourceLocation = SourceKey[1].Replace("\r", "");
                        Comment = SourceLocation;
                    }

                    msgctxt = SplitDataCsv[2];
                    msgid = SplitDataCsv[0];
                    msgstr = SplitDataCsv[1];

                    valid = true;
                }
            }
        }

        // Export Strings
        public string ExportCsvString ()
        {
            return msgid + "\t" + msgstr + "\t" + msgctxt + "\t" + "Key:" + Key + "SourceLocation:" + SourceLocation;
        }

        public string ExportPoString ()
        {
            string RetrunString = "";
            RetrunString = RetrunString + "#. Key:	" + Key + "\n"; // + Environment.NewLine;
            RetrunString = RetrunString + "#. SourceLocation:	" + SourceLocation + "\n";
            RetrunString = RetrunString + "#: " + Comment + "\n";
            RetrunString = RetrunString + "msgctxt \"" + msgctxt + "\"\n";
            RetrunString = RetrunString + "msgid \"" + msgid + "\"\n";
            RetrunString = RetrunString + "msgstr \"" + msgstr + "\"\n";
            return RetrunString;

        }

    }
}
