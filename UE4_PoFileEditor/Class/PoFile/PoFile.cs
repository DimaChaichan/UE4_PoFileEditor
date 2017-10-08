using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UE4_PoFileEditor.Class
{
    public class PoFile
    {
        public List<PoFileValues> Values = new List<PoFileValues>();
        public PoFile ()
        {

        }

        public PoFile(FileInfo Path)
        {
            if (Path.Exists)
            {
                LoadPoFile(Path, "\n\n");
            }
        }

        public void SaveFile(FileInfo SavePath)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(SavePath.FullName, true))
            {
                foreach (PoFileValues Value in Values)
                {
                    file.WriteLine(Value.ExportPoString());
                }
            }
        }

        private void LoadPoFile(FileInfo Path, string SplitChar)
        {
            if (Path.Exists)
            {
                string Data = File.ReadAllText(Path.FullName);
                string[] DataValues = Data.Split(new[] { SplitChar }, StringSplitOptions.None);
                foreach (var Value in DataValues)
                {
                    PoFileValues poFileValue = new PoFileValues(Value);
                    if(poFileValue.valid)
                    {
                        Values.Add(poFileValue);
                    }
                }
            }
        }
    }
}
