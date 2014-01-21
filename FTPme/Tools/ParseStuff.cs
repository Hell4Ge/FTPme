using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPme.Tools
{
    public static class ParseStuff
    {
        public static String createStr(String str, int pad)
        {
            return str.PadRight(10, 'x');
        }
    }
}
