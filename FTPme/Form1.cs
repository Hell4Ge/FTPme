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
            RowScheme rs = new RowScheme("foo", "1337", "Admin", "666", "God", "Me");
            fastDataListView1.AddObject(rs);
        }

    }
}
