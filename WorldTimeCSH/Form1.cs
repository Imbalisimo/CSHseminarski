using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTimeCSH
{
    public partial class Form1 : Form
    {
        int coefficient = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            coefficient =(int)numericUpDown1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            int hourHelper = DateTime.Now.Hour;
            hourHelper += coefficient;
            current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hourHelper, DateTime.Now.Minute, DateTime.Now.Second);
            textBox1.Text = current.ToLongTimeString();
        }
    }
}
