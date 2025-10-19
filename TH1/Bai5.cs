using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Bảng cửu chương")
            {
                if (int.TryParse(tb_numA.Text, out int a) && int.TryParse(tb_numB.Text, out int b) && b > a)
                {
                    int c = b - a;
                    string kq = "";
                    for (int i = 1; i <= 10; i++)
                    {
                        kq += c.ToString() + "x" + i.ToString() + " = " + (c * i).ToString() + "\r\n";
                    }
                    tb_result.Text = kq;
                }
                else MessageBox.Show("Vui lòng nhập số nguyên A và B thỏa B > A ", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox1.Text == "Tính toán giá trị")
            {
                if (int.TryParse(tb_numA.Text, out int a) && int.TryParse(tb_numB.Text, out int b) && a > b)
                {
                    int c = a - b;
                    string kq = "";
                    int s1 = 1, s2 = 0, s3 = 1;
                    for (int i = 1; i <= c; i++)
                    {
                        s1 *= i;
                    }
                    for (int i = 1; i <= b; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            s3 *= a;
                        }
                        s2 += s3;
                    }
                    kq += c.ToString() + "!=" + s1.ToString() + "\r\n" + "Tổng S= " + s2.ToString();
                    tb_result.Text = kq;
                }
                else MessageBox.Show("Vui lòng nhập số nguyên A và B thỏa A > B ", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
            tb_numA.Clear();
            tb_numB.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
