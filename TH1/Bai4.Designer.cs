namespace TH1
{
    partial class Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Datve = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_hoten = new TextBox();
            dgv_result = new DataGridView();
            hoten = new DataGridViewTextBoxColumn();
            phim = new DataGridViewTextBoxColumn();
            pc = new DataGridViewTextBoxColumn();
            loai = new DataGridViewTextBoxColumn();
            ghe = new DataGridViewTextBoxColumn();
            sotien = new DataGridViewTextBoxColumn();
            cbb_phim = new ComboBox();
            cbb_pc = new ComboBox();
            lb_thanhtoan = new Label();
            tb_sotien = new TextBox();
            cbb_ghe = new ComboBox();
            btn_xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_result).BeginInit();
            SuspendLayout();
            // 
            // btn_Datve
            // 
            btn_Datve.Font = new Font("Segoe UI", 12F);
            btn_Datve.Location = new Point(58, 164);
            btn_Datve.Name = "btn_Datve";
            btn_Datve.Size = new Size(109, 41);
            btn_Datve.TabIndex = 0;
            btn_Datve.Text = "Đặt vé";
            btn_Datve.UseVisualStyleBackColor = true;
            btn_Datve.Click += btn_Datve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(77, 24);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(89, 100);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 2;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(426, 24);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 3;
            label3.Text = "Phòng chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(467, 104);
            label4.Name = "label4";
            label4.Size = new Size(47, 28);
            label4.TabIndex = 4;
            label4.Text = "Ghế";
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new Point(236, 25);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new Size(125, 27);
            tb_hoten.TabIndex = 5;
            // 
            // dgv_result
            // 
            dgv_result.BackgroundColor = SystemColors.ActiveBorder;
            dgv_result.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_result.Columns.AddRange(new DataGridViewColumn[] { hoten, phim, pc, loai, ghe, sotien });
            dgv_result.Location = new Point(2, 233);
            dgv_result.Name = "dgv_result";
            dgv_result.RowHeadersWidth = 51;
            dgv_result.Size = new Size(798, 205);
            dgv_result.TabIndex = 9;
            // 
            // hoten
            // 
            hoten.HeaderText = "Họ tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            hoten.Width = 175;
            // 
            // phim
            // 
            phim.HeaderText = "Phim";
            phim.MinimumWidth = 6;
            phim.Name = "phim";
            phim.Width = 150;
            // 
            // pc
            // 
            pc.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            pc.HeaderText = "Phòng chiếu";
            pc.MinimumWidth = 6;
            pc.Name = "pc";
            pc.Width = 119;
            // 
            // loai
            // 
            loai.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            loai.HeaderText = "Loại vé";
            loai.MinimumWidth = 6;
            loai.Name = "loai";
            loai.Width = 85;
            // 
            // ghe
            // 
            ghe.HeaderText = "Ghế";
            ghe.MinimumWidth = 6;
            ghe.Name = "ghe";
            ghe.Width = 50;
            // 
            // sotien
            // 
            sotien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sotien.HeaderText = "Thành tiền";
            sotien.MinimumWidth = 6;
            sotien.Name = "sotien";
            // 
            // cbb_phim
            // 
            cbb_phim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_phim.FormattingEnabled = true;
            cbb_phim.Location = new Point(236, 104);
            cbb_phim.Name = "cbb_phim";
            cbb_phim.Size = new Size(151, 28);
            cbb_phim.TabIndex = 11;
            cbb_phim.SelectedIndexChanged += cbb_phim_SelectedIndexChanged;
            // 
            // cbb_pc
            // 
            cbb_pc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_pc.FormattingEnabled = true;
            cbb_pc.Location = new Point(565, 28);
            cbb_pc.Name = "cbb_pc";
            cbb_pc.Size = new Size(151, 28);
            cbb_pc.TabIndex = 12;
            cbb_pc.SelectedIndexChanged += cbb_pc_SelectedIndexChanged;
            // 
            // lb_thanhtoan
            // 
            lb_thanhtoan.AutoSize = true;
            lb_thanhtoan.Font = new Font("Segoe UI", 12F);
            lb_thanhtoan.ForeColor = Color.Red;
            lb_thanhtoan.Location = new Point(236, 172);
            lb_thanhtoan.Name = "lb_thanhtoan";
            lb_thanhtoan.Size = new Size(110, 28);
            lb_thanhtoan.TabIndex = 15;
            lb_thanhtoan.Text = "Thanh toán";
            // 
            // tb_sotien
            // 
            tb_sotien.BackColor = SystemColors.Control;
            tb_sotien.BorderStyle = BorderStyle.None;
            tb_sotien.Font = new Font("Segoe UI", 15F);
            tb_sotien.Location = new Point(389, 177);
            tb_sotien.Name = "tb_sotien";
            tb_sotien.ReadOnly = true;
            tb_sotien.Size = new Size(125, 34);
            tb_sotien.TabIndex = 16;
            tb_sotien.TextChanged += tb_sotien_TextChanged;
            // 
            // cbb_ghe
            // 
            cbb_ghe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_ghe.FormattingEnabled = true;
            cbb_ghe.Location = new Point(565, 104);
            cbb_ghe.Name = "cbb_ghe";
            cbb_ghe.Size = new Size(151, 28);
            cbb_ghe.TabIndex = 17;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(605, 164);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(111, 36);
            btn_xoa.TabIndex = 18;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_xoa);
            Controls.Add(cbb_ghe);
            Controls.Add(tb_sotien);
            Controls.Add(lb_thanhtoan);
            Controls.Add(cbb_pc);
            Controls.Add(cbb_phim);
            Controls.Add(dgv_result);
            Controls.Add(tb_hoten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Datve);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_result).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Datve;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_hoten;
        private DataGridView dgv_result;
        private ComboBox cbb_phim;
        private ComboBox cbb_pc;
        private Label lb_thanhtoan;
        private TextBox tb_sotien;
        private ComboBox cbb_ghe;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn phim;
        private DataGridViewTextBoxColumn pc;
        private DataGridViewTextBoxColumn loai;
        private DataGridViewTextBoxColumn ghe;
        private DataGridViewTextBoxColumn sotien;
        private Button btn_xoa;
    }
}