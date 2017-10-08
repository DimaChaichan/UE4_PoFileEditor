using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class SettingsValue
    {
        string Group_;
        public string Group
        {
            get { return Group_; }
            set { Group_ = value; }
        }

        public string Name { get; set; }

        object Settingsvalue_;
        public object Settingsvalue
        {
            get { return Settingsvalue_; }
            set { Settingsvalue_ = value; }
        }

        public SettingsValue(string Group,string Name, object Value)
        {
            this.Group = Group;
            this.Settingsvalue_ = Value;
            this.Name = Name;
        }

    }
}
