using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EbookReader.Services
{
    class Utilities
    {
        public static string[] getDirs()
        {
            string dir = System.IO.Path.GetFullPath("..\\..\\..\\Books");
            string[] dirs = Directory.GetDirectories(dir);
            return dirs;
        }

    }
}
