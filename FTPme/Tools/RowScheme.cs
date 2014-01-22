using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTPme.Tools
{
    public class RowScheme
    {

        static string rights;
        static string hl;
        static string uid;
        static string gid;
        static string size;
        //static DateTime dt;
        static string name;

        // =====================================================================================
        //     [0]       [1]     [2]         [3]            [4]          [5-7]           [8]    ||
        //  ==RIGHTS==  =HL=    =UID=     == GID ==      == SIZE ==  === DATE ===  == FNAME ==  ||
        //  drwxrwxr-x    6    1089909    www-data         4096       Dec 18 23:49  templates|  ||
        //  -rw-rw-r--    1    1089909    www-data            0       Jan 20 03:38  test.txt|   ||
        // =====================================================================================

        public RowScheme(string Rights , string Hardlinks, string UID, string GID, string Size, /*DateTime Dt,*/ string Name)
        {
            rights = Rights;
            hl = Hardlinks;
            uid = UID;
            gid = GID;
            size = Size;
            //dt = Dt;
            name = Name;
        }

        /*
        public string LMDate
        {
            get { 
                string date ="";
                date += dt.Day.ToString() + ':' + dt.Month.ToString() + ':' + dt.Year.ToString();
                return date;
            }
        }
        */

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string HL
        {
            get { return hl; }
            set { hl = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public string GID
        {
            get { return gid; }
            set { gid = value; }
        }

        public string Rights
        {
            get { return rights; }
            set { rights = value; }
        }

        static internal List<RowScheme> GET()
        {
            // public RowScheme(string Rights , string Hardlinks, string UID, string GID, string Size, DateTime Dt, string Name)
            RowScheme item = new RowScheme(rights,  hl, uid, gid, size, /*dt,*/ name);
            
            List<RowScheme> ret = new List<RowScheme>();
            ret.Add(item);
            //Form1.richDebug.AppendText("Created new row" + '\n');
            
            return ret;
        }
    }
}
