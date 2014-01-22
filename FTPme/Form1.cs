using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FTPme.Tools;

namespace FTPme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FTPManager ftp = new FTPManager(@"ftp://cba.pl", "admin@demoncraft.c0.pl", "bodzio17");
            List<RowScheme> dirs = ftp.SchemeRowList("/");

            fastDataListView1.SetObjects(dirs, true);
        }

    }
}
