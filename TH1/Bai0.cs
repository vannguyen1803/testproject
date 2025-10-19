using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1
{
    public partial class Bai0 : Form
    {
        public Bai0()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_num1.Text, out int num1) && int.TryParse(tb_num2.Text, out int num2))
            {
                int sum = num1 + num2;
                tb_result.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "Canh bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
