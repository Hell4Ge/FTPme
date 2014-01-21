using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPme.Tools
{
    public class RowScheme
    {
        static string name;
        static string size;
        static string creation;
        static string rights;
        static string type;
        static string og;

        public RowScheme(string Name , string Size, string Creation, string Rights, string Type, string Og)
        {
            name = Name;
            size = Size;
            creation = Creation;
            rights = Rights;
            type = Type;
            og = Og;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Creation
        {
            get { return creation; }
            set { creation = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Rights
        {
            get { return rights; }
            set { rights = value; }
        }

        public string OG
        {
            get { return og; }
            set { og = value; }
        } 

        static internal List<RowScheme> GET()
        {
            RowScheme item = new RowScheme(name,  size, creation, rights, type, og);
            
            List<RowScheme> ret = new List<RowScheme>();
            return ret;
        }
    }
}
