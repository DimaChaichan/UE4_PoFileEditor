using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class ListIntValue
    {
        int intValue_;
        public int intValue 
        {
            get { return intValue_; }
            set { intValue_ = value; }
        }

        string intName_;
        public string intName
        {
            get { return intName_; }
        }

        public ListIntValue(string Name, int intValue)
        {
            intName_ = Name;
            intValue_ = intValue;
        }
    }
}
