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
    public partial class Bai4 : Form
    {
        private enum LoaiVe { Vot, Thuong, VIP };

        private List<string> createListGhe(int so_hang, int so_luong_ghe)
        {
            List<string> cho_ngoi = new List<string>();
            for (char i = 'A'; i < ('A' + so_hang); i++)
            {
                for (int j = 1; j <= so_luong_ghe; j++)
                {
                    cho_ngoi.Add($"{i}{j}");
                }
            }
            return cho_ngoi;
        }

        private LoaiVe XacDinhLoaiVe(string vi_tri_ghe)
        {
            if (vi_tri_ghe == "A2" || vi_tri_ghe == "A3" || vi_tri_ghe == "A4" || vi_tri_ghe == "C2" || vi_tri_ghe == "C3" || vi_tri_ghe == "C4")
            {
                return LoaiVe.Thuong;
            }
            else if (vi_tri_ghe == "B2" || vi_tri_ghe == "B3" || vi_tri_ghe == "B4")
            {
                return LoaiVe.VIP;
            }

            return LoaiVe.Vot;
        }
        private class Phim
        {
            public string ten;
            public double gia_ve;
            public Dictionary<string, List<string>> phong_chieu;

            public Phim(string ten, double gia_ve)
            {
                this.ten = ten;
                this.gia_ve = gia_ve;
                this.phong_chieu = new Dictionary<string, List<string>>();
            }

            public bool CoChoNgoi(string ten_phong_chieu, string vi_tri_ghe)
            {
                if (!phong_chieu.ContainsKey(ten_phong_chieu))
                {
                    return false;
                }

                return phong_chieu[ten_phong_chieu].Contains(vi_tri_ghe);
            }

            public double ThanhTien(LoaiVe loaive)
            {
                if (loaive == LoaiVe.Vot)
                {
                    return (1 / (double)4) * gia_ve;
                }
                else if (loaive == LoaiVe.VIP)
                {
                    return 2 * gia_ve;
                }

                return gia_ve;
            }
        }
        Dictionary<string, Phim> danh_sach_phim;
        public Bai4()
        {
            danh_sach_phim = new Dictionary<string, Phim>();
            InitializeComponent();
            lb_thanhtoan.Visible = false;
            Phim temp = new Phim("Đào, phở và piano", 45000);
            temp.phong_chieu.Add("1", createListGhe(3, 5));
            temp.phong_chieu.Add("2", createListGhe(3, 5));
            temp.phong_chieu.Add("3", createListGhe(3, 5));
            danh_sach_phim.Add("Đào, phở và piano", temp);

            temp = new Phim("Mai", 100000);
            temp.phong_chieu.Add("2", createListGhe(3, 5));
            temp.phong_chieu.Add("3", createListGhe(3, 5));
            danh_sach_phim.Add("Mai", temp);

            temp = new Phim("Gặp lại chị bầu", 70000);
            temp.phong_chieu.Add("1", createListGhe(3, 5));
            danh_sach_phim.Add("Gặp lại chị bầu", temp);

            temp = new Phim("Tarot", 90000);
            temp.phong_chieu.Add("3", createListGhe(3, 5));
            danh_sach_phim.Add("Tarot", temp);

            cbb_phim.DataSource = danh_sach_phim.Keys.ToList();
            cbb_pc.Enabled = false;
            cbb_ghe.Enabled = false;
        }
        private void cbb_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_pc.Enabled = true;


            if (cbb_phim.SelectedItem == null)
            {
                cbb_phim.SelectedIndex = 0;
            }

            //Thêm các phòng chiếu mà một phim được chiếu
            string selected = cbb_phim.SelectedItem.ToString();
            cbb_pc.DataSource = danh_sach_phim[selected].phong_chieu.Keys.ToList();
        }
        private void cbb_pc_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_ghe.Enabled = true;


            //Thêm các vị trí ghế có thể đặt
            string ten_phim = cbb_phim.SelectedItem.ToString();
            string selected = cbb_pc.SelectedItem.ToString();
            cbb_ghe.DataSource = danh_sach_phim[ten_phim].phong_chieu[selected].ToArray();
        }

        private void btn_Datve_Click(object sender, EventArgs e)
        {
            if (tb_hoten.Text.Length == 0 || cbb_phim.SelectedIndex == -1 || cbb_pc.SelectedIndex == -1 || cbb_ghe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string ten_nguoi_mua = tb_hoten.Text;
                string ten_phim = cbb_phim.SelectedItem.ToString();
                string phong_chieu = cbb_pc.SelectedItem.ToString();
                string vi_tri_ghe = cbb_ghe.SelectedItem.ToString();
                string loaiVe_str;
                LoaiVe loaiVe = XacDinhLoaiVe(vi_tri_ghe);
                if (loaiVe == LoaiVe.Thuong)
                {
                    loaiVe_str = "Thường";
                }
                else if (loaiVe == LoaiVe.VIP)
                {
                    loaiVe_str = "VIP";
                }
                else
                {
                    loaiVe_str = "Vớt";
                }
                lb_thanhtoan.Visible = true;
                tb_sotien.Text = danh_sach_phim[ten_phim].ThanhTien(loaiVe).ToString();
                dgv_result.Rows.Add(ten_nguoi_mua, ten_phim, phong_chieu, loaiVe_str, vi_tri_ghe, danh_sach_phim[ten_phim].ThanhTien(loaiVe));
                danh_sach_phim[ten_phim].phong_chieu[phong_chieu].Remove(vi_tri_ghe);
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void tb_sotien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_hoten.Clear();
            tb_sotien.Clear();
            lb_thanhtoan.Visible=false;
            cbb_phim.Items.Clear();
            cbb_pc.Items.Clear();
            cbb_ghe.Items.Clear();
        }
    }
}
