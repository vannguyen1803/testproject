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
    public partial class Bai8 : Form
    {
        List<string> listmon = new List<string>();
        string s = "";
        public Bai8()
        {
            InitializeComponent();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tb_monan.Text)) MessageBox.Show("Vui lòng nhập tên món ăn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                listmon.Add(tb_monan.Text);
                s += tb_monan.Text + "\r\n";
                tb_list.Text = s;
                tb_monan.Clear();
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (listmon.Count > 0)
            {
                Random random = new Random();
                int n = random.Next(listmon.Count);
                tb_result.Text = listmon[n];
            }
            else MessageBox.Show("Vui lòng nhập ít nhất 1 món ăn", "Cảnh báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
            tb_monan.Clear();
            tb_list.Clear();
            listmon.Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
