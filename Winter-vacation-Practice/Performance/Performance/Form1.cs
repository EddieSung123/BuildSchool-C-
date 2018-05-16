using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Performance
{
    public partial class Form1 : Form
    {
        private List<shop> _list;
        private List<shop2> _list2;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            dataGridView2.DataSource = _list;
            CreateList2();
            dataGridView1.DataSource = _list2;
            lables();

        }

        private List<shop> CreateList()
        {
            
            _list = new List<shop>();
            _list.Add(new shop { Name = "Bill", pen = 33, pencil = 32, eraser = 56, ruler = 45, white = 33});
            _list.Add(new shop { Name = "John", pen = 77, pencil = 33, eraser = 68, ruler = 45, white = 23});
            _list.Add(new shop { Name = "David", pen = 43, pencil = 55, eraser = 43, ruler = 67, white = 65});

            return _list;
        }

        private List<shop2> CreateList2()
        {
            _list2 = new List<shop2>();
            _list2.Add(new shop2 { sample = "原子筆", sale = 12, sales = 153});
            _list2.Add(new shop2 { sample = "鉛筆", sale = 16, sales = 120});
            _list2.Add(new shop2 { sample = "橡皮擦", sale = 10, sales = 167});
            _list2.Add(new shop2 { sample = "尺", sale = 14, sales = 157});
            _list2.Add(new shop2 { sample = "立可白", sale = 15, sales = 121});

            return _list2;

        }

        private void lables()
        {
            var m = _list.Where((x) => x.money == _list.Max((y) => y.money));
            foreach(var better in m)
            {
                label5.Text = better.Name;
            }
            var s = _list2.Where((x) => x.money2 == _list2.Max((y) => y.money2));
            foreach (var saleb in s)
            {
                label6.Text = saleb.sample;
            }


        }

    }

    
}
