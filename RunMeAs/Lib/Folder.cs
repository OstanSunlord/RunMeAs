using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunMeAs
{
    public static class Folder
    {
        public static string ProgramFolder
        {
            get
            {
                var folder = Environment.SpecialFolder.LocalApplicationData;
                var programFolder = Path.Combine(Environment.GetFolderPath(folder), "RunMeAsApp");

                if (!Directory.Exists(programFolder))
                {
                    Directory.CreateDirectory(programFolder);
                }

                return programFolder;
            }
        }
    }
}
