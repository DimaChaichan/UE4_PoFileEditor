using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class cl_ListKeyBool
    {
        public string Key { get; set; }
        public bool Bool { get; set; }

        public cl_ListKeyBool(string Key, bool Bool)
        {
            this.Key = Key;
            this.Bool = Bool;
        }
    }
}
