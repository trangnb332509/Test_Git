using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                string ext = o.FileName.Substring(o.FileName.IndexOf('.'));
                string filename = Guid.NewGuid().ToString() + ext;
                textBox1.Text = filename;

                string[] lines = System.IO.File.ReadAllLines(@"E:employees.txt");
                DataTable dt = new DataTable();
                foreach (string s in lines)
                {
                    DataRow r = dt.NewRow();
                }
            }
        }
    }
}
