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
        CultureInfo cultureInfo = new CultureInfo("hr-HR");
        TimeSpan ts;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(CultureInfo.GetCultures(CultureTypes.AllCultures));
            comboBox2.Items.AddRange(TimeZoneInfo.GetSystemTimeZones().ToArray<TimeZoneInfo>());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime current;
            int hourHelper = DateTime.Now.Hour;
            hourHelper +=ts.Hours;
            hourHelper %= 24;
            if (hourHelper < 0)
                hourHelper = 24 + hourHelper;
            current = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hourHelper, DateTime.Now.Minute, DateTime.Now.Second);
            textBox1.Text = current.ToString(cultureInfo);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cultureInfo = (CultureInfo)comboBox1.SelectedItem;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeZoneInfo tzi = (TimeZoneInfo)comboBox2.SelectedItem;
            ts = tzi.BaseUtcOffset;
        }
    }
}
