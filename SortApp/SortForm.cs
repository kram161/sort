using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SortLibrary.Sorts;

namespace SortApp
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private int[] StrToArr(string t)
        {
            string[] split = t.Split();
            int[] Arr = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                if(!int.TryParse(split[i],out Arr[i]))
                    throw new Exception("некорректный ввод");
            }
            return Arr;
        }
        private void SortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int[] A = StrToArr(InputA.Text);
                int[] B = StrToArr(InputB.Text);
                int[] C = SortAndUnion(A, B);
                OutC.Text = string.Join(" ", C);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
