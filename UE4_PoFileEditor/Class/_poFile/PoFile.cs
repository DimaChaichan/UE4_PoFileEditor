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
                LoadPoFile(Path);
            }
        }

        public void SaveFile(FileInfo SavePath)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(SavePath.FullName))
            {
                foreach (PoFileValues Value in Values)
                {
                    file.WriteLine(Value.ExportPoString());
                }
            }
        }

        private void LoadPoFile(FileInfo Path)
        {
            if (Path.Exists)
            {
                string Data = File.ReadAllText(Path.FullName);
                string[] DataValues = Data.Split(new[] { "\n\n" }, StringSplitOptions.None);
                if(DataValues.Length <= 1)
                   DataValues = Data.Split(new[] { "\n\r\n" }, StringSplitOptions.None);

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
