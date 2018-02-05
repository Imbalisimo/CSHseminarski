using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldTimeCSH
{
    public partial class Form1 : Form
    {
        int coefficient = -1;
        CultureInfo cultureInfo = new CultureInfo("hr-HR");

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            coefficient =(int)numericUpDown1.Value-1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime current;
            int hourHelper = DateTime.Now.Hour;
            hourHelper += coefficient;
            current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hourHelper, DateTime.Now.Minute, DateTime.Now.Second, cultureInfo.Calendar);
            textBox1.Text = current.ToLongDateString()+", "+current.ToLongTimeString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cultureInfo = new CultureInfo(comboBox1.SelectedText);
        }

    }
}
