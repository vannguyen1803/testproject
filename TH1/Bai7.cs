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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            string s = (string)tb_nhap.Text;
            string[] chia = s.Split(',');

            if (chia.Length < 2)
            {
                MessageBox.Show("Vui lòng nhập đủ họ tên và điểm số", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(chia[0]) || string.IsNullOrWhiteSpace(chia[1].Trim()))
            {
                MessageBox.Show("Vui lòng nhập đủ họ tên và điểm số", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string result = "Họ tên: " + chia[0].Trim() + "\r\n";

                List<double> d = new List<double>();
                bool hople = true;
                for (int i = 1; i < chia.Length; i++)
                {
                    string ds = chia[i].Trim();
                    if (string.IsNullOrEmpty(ds))
                        continue;

                    if (double.TryParse(ds, CultureInfo.InvariantCulture, out double diem) && diem >= 0 && diem <= 10)
                    {
                        d.Add(diem);
                        result += "Môn" + i.ToString() + ": " + diem.ToString() + "\r\n";
                    }
                    else
                    {
                        hople = false;
                        break;
                    }
                }

                if (!hople || d.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập điểm số trong khoảng [0;10]", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double a = d.Average(), min = d.Min(), max = d.Max();
                    tb_result.Text = result;
                    tb_trungbinh.Text = a.ToString();
                    tb_min.Text = min.ToString();
                    tb_max.Text = max.ToString();
                    int cdau = d.Count(n => n >= 5);
                    tb_dau.Text = cdau.ToString();
                    tb_kodau.Text = (d.Count() - cdau).ToString();
                    switch (a)
                    {
                        case double v when (a >= 8 && min >= 6.5):
                            tb_xeploai.Text = "Giỏi";
                            break;
                        case double v when (a >= 6.5 && min >= 5):
                            tb_xeploai.Text = "Khá";
                            break;
                        case double v when (a >= 5 && min >= 3.5):
                            tb_xeploai.Text = "Trung bình";
                            break;
                        case double v when (a >= 3.5 && min >= 2):
                            tb_xeploai.Text = "Yếu";
                            break;
                        default:
                            tb_xeploai.Text = "Kém";
                            break;
                    }
                }
            }
        }
    }
}
