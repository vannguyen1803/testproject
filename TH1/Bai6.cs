using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH1
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            cbb_ngay.Enabled = false;

        }

        private void cbb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = cbb_thang.SelectedIndex + 1;
            int day;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    day = 29;
                    break;
                default:
                    day = 30;
                    break;
            }
            cbb_ngay.Items.Clear();
            for (int i = 1; i <= day; i++)
            {
                cbb_ngay.Items.Add(i);
            }
            cbb_ngay.Enabled = true;

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (cbb_ngay.SelectedIndex != -1 && cbb_thang.SelectedIndex != -1)
            {
                int thang = cbb_thang.SelectedIndex + 1;
                int ngay = cbb_ngay.SelectedIndex + 1;
                switch (thang)
                {
                    case int n when (thang == 3 && ngay >= 21) || (thang == 4 && ngay <= 20):
                        tb_result.Text = "Bạch Dương";
                        break;
                    case int n when (thang == 4 && ngay >= 21) || (thang == 5 && ngay <= 21):
                        tb_result.Text = "Kim Ngưu";
                        break;
                    case int n when (thang == 5 && ngay >= 22) || (thang == 6 && ngay <= 21):
                        tb_result.Text = "Song Tử";
                        break;
                    case int n when (thang == 6 && ngay >= 22) || (thang == 7 && ngay <= 22):
                        tb_result.Text = "Cự Giải";
                        break;
                    case int n when (thang == 7 && ngay >= 23) || (thang == 8 && ngay <= 22):
                        tb_result.Text = "Sư Tử";
                        break;
                    case int n when (thang == 8 && ngay >= 23) || (thang == 9 && ngay <= 23):
                        tb_result.Text = "Cự Giải";
                        break;
                    case int n when (thang == 9 && ngay >= 24) || (thang == 10 && ngay <= 23):
                        tb_result.Text = "Thiên Bình";
                        break;
                    case int n when (thang == 10 && ngay >= 24) || (thang == 11 && ngay <= 22):
                        tb_result.Text = "Thần Nông";
                        break;
                    case int n when (thang == 11 && ngay >= 23) || (thang == 12 && ngay <= 21):
                        tb_result.Text = "Nhân Mã";
                        break;
                    case int n when (thang == 12 && ngay >= 22) || (thang == 1 && ngay <= 20):
                        tb_result.Text = "Ma Kết";
                        break;
                    case int n when (thang == 1 && ngay >= 21) || (thang == 2 && ngay <= 19):
                        tb_result.Text = "Bảo Bình";
                        break;
                    case int n when (thang == 2 && ngay >= 20) || (thang == 3 && ngay <= 20):
                        tb_result.Text = "Song Ngư";
                        break;
                }
            }
            else {
                MessageBox.Show("Vui lòng nhập lại ngày tháng sinh", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
            cbb_ngay.Items.Clear();
            cbb_thang.SelectedIndex = -1;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
