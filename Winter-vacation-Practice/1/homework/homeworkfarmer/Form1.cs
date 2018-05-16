using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeworkfarmer
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDataSource();
            ChangeData();
            
        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "農夫","狼","羊","花椰菜"
            };
            _rightList = new List<string>();
        }

        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One; //SelectionMode是enum列矩值
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
            if (_leftList.Contains("農夫"))  //判斷有沒有農夫
            {
                if ((string)listBox1.SelectedItem == "農夫") //如果選擇農夫
                {
                    _leftList.Remove("農夫"); //左移除農夫
                    _rightList.Add("農夫");   //右新增農夫
                    ChangeData();
                }
                else //如果選擇不是農夫
                {
                    string item = (string)listBox1.SelectedItem; //選擇的項目為item
                    _leftList.Remove(item); //左邊移除item
                    _rightList.Add(item);//右邊新增item
                    _leftList.Remove("農夫");//左移除農夫
                    _rightList.Add("農夫");//右新增農夫
                    ChangeData(); //重整
                    
                }
                if (_leftList.Contains("狼") && _leftList.Contains("羊") && _rightList.Contains("農夫") ||
                    _leftList.Contains("花椰菜") && _leftList.Contains("羊") && _rightList.Contains("農夫"))
                {
                    MessageBox.Show("渡河失敗");
                }

            }

            if (_leftList.Count==0)
           {
                MessageBox.Show("恭喜成功");
            }
        }

    private void button2_Click(object sender, EventArgs e)
        {
            if (_rightList.Contains("農夫"))  //判斷有沒有農夫
            {
                if ((string)listBox2.SelectedItem == "農夫") //如果選擇農夫
                {
                    _rightList.Remove("農夫"); //右移除農夫
                    _leftList.Add("農夫");   //左新增農夫
                    ChangeData();
                }
                else
                {
                    string item = (string)listBox2.SelectedItem;//選擇的選項是item
                    _rightList.Remove(item); //右邊移除item
                    _leftList.Add(item); //左邊新增item
                    _rightList.Remove("農夫"); //右移除農夫
                    _leftList.Add("農夫");//左新增農夫
                    ChangeData(); //重整
                }
                if (_rightList.Contains("狼") && _rightList.Contains("羊") ||
                    _rightList.Contains("花椰菜") && _rightList.Contains("羊") )
                {
                    MessageBox.Show("渡河失敗");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateList();
            ChangeData();
        }
    }
}
