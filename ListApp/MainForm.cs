using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListLibrary;

namespace ListApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetCount_Click(object sender, EventArgs e)
        {
            try
            {
                IntList list = new IntList();
                string[] inp = ListInput.Text.Split();
                for (int i = 0; i < inp.Length; i++)
                {
                    list.Add(int.Parse(inp[i]));
                }
                CountOutput.Text = list.GetCountWithValue((int)InputA.Value).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("некорректный ввод", "ошибка");
            }
        }
    }
}
