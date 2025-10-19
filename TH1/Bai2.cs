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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_doc_bai2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tb_num.Text, out int num) && num / 10 == 0)
            {
                switch (num)
                {
                    case 0:
                        tb_result.Text = "Không";
                        break;
                    case 1:
                        tb_result.Text = "Một";
                        break;
                    case 2:
                        tb_result.Text = "Hai";
                        break;
                    case 3:
                        tb_result.Text = "Ba";
                        break;
                    case 4:
                        tb_result.Text = "Bốn";
                        break;
                    case 5:
                        tb_result.Text = "Năm";
                        break;
                    case 6:
                        tb_result.Text = "Sáu";
                        break;
                    case 7:
                        tb_result.Text = "Bảy";
                        break;
                    case 8:
                        tb_result.Text = "Tám";
                        break;
                    case 9:
                        tb_result.Text = "Chín";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số từ 0 đến 9", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
