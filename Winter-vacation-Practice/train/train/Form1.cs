using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace train
{
    public partial class Form1 : Form
    {
        private List<Class1> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();

        }

        private void CreateList()
        {
            _list = new List<Class1>();
            _list.Add(new Class1 { start = "台北", end = "新竹", money = 177 });
            _list.Add(new Class1 { start = "台北", end = "台中", money = 375 });
            _list.Add(new Class1 { start = "台北", end = "嘉義", money = 598 });
            _list.Add(new Class1 { start = "台北", end = "台南", money = 738 });
            _list.Add(new Class1 { start = "台北", end = "高雄", money = 842 });
            _list.Add(new Class1 { start = "新竹", end = "台中", money = 197 });
            _list.Add(new Class1 { start = "新竹", end = "嘉義", money = 421 });
            _list.Add(new Class1 { start = "新竹", end = "台南", money = 560 });
            _list.Add(new Class1 { start = "新竹", end = "高雄", money = 577 });
            _list.Add(new Class1 { start = "台中", end = "嘉義", money = 224 });
            _list.Add(new Class1 { start = "台中", end = "台南", money = 363 });
            _list.Add(new Class1 { start = "台中", end = "高雄", money = 469 });
            _list.Add(new Class1 { start = "嘉義", end = "台南", money = 139 });
            _list.Add(new Class1 { start = "嘉義", end = "高雄", money = 245 });
            _list.Add(new Class1 { start = "台南", end = "高雄", money = 106 });

        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = _list.GroupBy((x) => x.start).Select((x) => x.Key).ToList();
            comboBox2.DataSource = _list.GroupBy((x) => x.end).Select((x) => x.Key).ToList();

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.DataSource = _list.GroupBy((x) => x.end).Select((x) => x.Key).ToList();
            comboBox2.DataSource = _list.GroupBy((x) => x.start).Select((x) => x.Key).ToList();
        }
        IEnumerable<int> price;
        private void Price()
        {
            string start1 = comboBox1.SelectedItem.ToString();
            string end1 = comboBox2.SelectedItem.ToString();
           
            if (radioButton1.Checked)
            {
               price = _list.Where((x) => x.start == start1).Where((x) => x.end == end1).Select((x) => x.money);
            }
            else
            {
                price = _list.Where((x) => x.end == start1).Where((x) => x.start == end1).Select((x) => x.money);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Price();


            if (checkBox1.Checked && checkBox2.Checked)
            {
                foreach (var i in price)
                {
                    label4.Text = Math.Round(2*i * 0.81,0).ToString();
                }
            }
            else if (checkBox1.Checked)
            {
                foreach (var i in price)
                {
                    label4.Text = Math.Round(2*i * 0.9, 0).ToString();
                }
            }
            else if (checkBox2.Checked)
            {
                foreach (var i in price)
                {
                    label4.Text = Math.Round(i * 0.9, 0).ToString();
                }
            }
            else
            {
                foreach (var i in price)
                {
                    label4.Text = i.ToString();
                }
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
