using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windowshomework
{
    public partial class Form1 : Form
    {
        private List<MyRectangle> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetCombobox();
        }

        private void CreateList()
        {
            _list = new List<Windowshomework.MyRectangle>();
            _list.Add(new MyRectangle { Name = "D1", Width = 5, Height = 5 });
            _list.Add(new MyRectangle { Name = "D2", Width = 10, Height = 10 });
            _list.Add(new MyRectangle { Name = "D3", Width = 20, Height = 20 });
            _list.Add(new MyRectangle { Name = "D4", Width = 100, Height = 100 });
        }

        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.ValueMember = "Area";
            comboBox1.DisplayMember = "Name";

        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            int area = (int)comboBox1.SelectedValue;
            MessageBox.Show(area.ToString());
        }
    }
}

