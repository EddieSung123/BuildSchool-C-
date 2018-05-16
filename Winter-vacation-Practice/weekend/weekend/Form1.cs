using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weekend
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textBox1.Text); //+ 1911;
            DateTime startDate = new DateTime(value, 1, 1);
            DateTime endDate = new DateTime(value, 12, 31);
            int holiday1 = 0;
            int holiday2 = 0;
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {               
                if (date.DayOfWeek == DayOfWeek.Saturday)
                {
                    holiday1 += 1;
                }
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holiday2 += 1;
                }
            }
            label1.Text = holiday1.ToString();
            label2.Text = holiday2.ToString();
        }
    }
}
