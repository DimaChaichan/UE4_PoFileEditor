using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsController
{
    public class StatusColor
    {
        Color color_;
        public Color color 
        {
            get { return color_; }
            set { color_ = value; }
        }

        string status_;
        public string status
        {
            get { return status_; }
        }

        public StatusColor(string status, Color color)
        {
            color_ = color;
            status_ = status;
        }
    }
}
