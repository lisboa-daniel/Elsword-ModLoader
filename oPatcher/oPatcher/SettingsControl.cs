using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oPatcher
{
    public class SettingsControl
    {
        public string launcherPath { get; set; }
        public Boolean minWhenStart { get; set; }
        public Boolean startMinimized { get; set; }
        public Boolean startWithWindows { get; set; }
        public List<string> activeMods = new List<string>();
    }
}
