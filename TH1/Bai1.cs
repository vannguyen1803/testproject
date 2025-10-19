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

namespace TH1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_tim_bai2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_num1.Text, CultureInfo.InvariantCulture, out double num1) && double.TryParse(tb_num2.Text, CultureInfo.InvariantCulture, out double num2) && double.TryParse(tb_num3.Text, CultureInfo.InvariantCulture, out double num3))
            {
                double nummax = Math.Max(num1, Math.Max(num2, num3));
                tb_max.Text = nummax.ToString();
                double nummin = Math.Min(num1, Math.Min(num2, num3));
                tb_min.Text = nummin.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số thực", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_num1.Clear();
            tb_num2.Clear();
            tb_num3.Clear();
            tb_max.Clear();
            tb_min.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
