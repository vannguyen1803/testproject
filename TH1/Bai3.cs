using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void tb_num_TextChanged(object sender, EventArgs e)
        {

        }
        private string Doc3So(int n)
        {
            string[] donvi = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int tram = n / 100;
            int chuc = (n % 100) / 10;
            int dv = n % 10;
            string s = "";
            if (tram > 0)
            {
                s += donvi[tram] + " trăm";
                if (chuc == 0 && dv > 0) s += " lẻ" + donvi[dv];
            }
            if (chuc > 1)
            {
                s += " " + donvi[chuc] + " mươi";
                if (dv == 1) s += " mốt";
                else if (dv == 5) s += " lăm";
                else if (dv > 0) s += " " + donvi[dv];
            }
            else if (chuc == 1)
            {
                s += " mười";
                if (dv == 5) s += " lăm";
                else s += " " + donvi[dv];
            }
            else s = donvi[dv];
            return s.Trim();
        }
        private string DocSo(long n)
        {
            string[] hang = { "", "nghìn", "triệu", "tỷ" };
            string kq = "";
            int i = 0;
            while (n > 0)
            {
                int a = (int)n % 1000;
                string s = Doc3So(a);
                if (a > 0)
                    kq = s + " " + hang[i] + " " + kq;
                n /= 1000;
                i++;
            }
            return kq;
        }
        private void btn_doc_bai2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_num.Text, out int num) && (num > 0) && (tb_num.TextLength <= 12))
            {
                if (num == 0)
                {
                    tb_result.Text = "Không";
                    return;
                }
                string result = DocSo(num);
                tb_result.Text = result;
                return;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương tối đa 12 chữ số", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_bai2_Click(object sender, EventArgs e)
        {
            tb_num.Clear();
            tb_result.Clear();
        }

        private void btn_thoat_bai2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
