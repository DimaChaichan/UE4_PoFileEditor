using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class cl_ListKeyInt
    {
        public string Key { get; set; }
        public int value { get; set; }

        public cl_ListKeyInt(string Key, int value)
        {
            this.Key = Key;
            this.value = value;
        }
    }
}
