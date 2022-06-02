using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunMeAs
{
    [Serializable]
    public class LoadSettings
    {
        public string FilePath { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RunAsAdmin { get; set; }
    }
}
