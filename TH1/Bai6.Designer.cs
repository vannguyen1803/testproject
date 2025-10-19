namespace TH1
{
    partial class Bai6
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
            label1 = new Label();
            label2 = new Label();
            cbb_thang = new ComboBox();
            cbb_ngay = new ComboBox();
            btn_tim = new Button();
            label3 = new Label();
            tb_result = new TextBox();
            btn_xoa = new Button();
            btn_thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(78, 42);
            label1.Name = "label1";
            label1.Size = new Size(191, 32);
            label1.TabIndex = 0;
            label1.Text = "Chọn tháng sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(85, 74);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 1;
            label2.Text = "Chọn ngày sinh";
            // 
            // cbb_thang
            // 
            cbb_thang.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_thang.Font = new Font("Segoe UI", 14F);
            cbb_thang.FormattingEnabled = true;
            cbb_thang.Items.AddRange(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });
            cbb_thang.Location = new Point(379, 35);
            cbb_thang.Name = "cbb_thang";
            cbb_thang.Size = new Size(151, 39);
            cbb_thang.TabIndex = 2;
            cbb_thang.SelectedIndexChanged += cbb_thang_SelectedIndexChanged;
            // 
            // cbb_ngay
            // 
            cbb_ngay.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_ngay.Font = new Font("Segoe UI", 14F);
            cbb_ngay.FormattingEnabled = true;
            cbb_ngay.Location = new Point(379, 83);
            cbb_ngay.Name = "cbb_ngay";
            cbb_ngay.Size = new Size(151, 39);
            cbb_ngay.TabIndex = 3;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 14F);
            btn_tim.Location = new Point(121, 141);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(127, 57);
            btn_tim.TabIndex = 4;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(64, 249);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 5;
            label3.Text = "Cung hoàng đạo";
            // 
            // tb_result
            // 
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(322, 249);
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(300, 39);
            tb_result.TabIndex = 6;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 14F);
            btn_xoa.Location = new Point(334, 141);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(127, 57);
            btn_xoa.TabIndex = 7;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 14F);
            btn_thoat.Location = new Point(547, 141);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(127, 57);
            btn_thoat.TabIndex = 8;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(tb_result);
            Controls.Add(label3);
            Controls.Add(btn_tim);
            Controls.Add(cbb_ngay);
            Controls.Add(cbb_thang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbb_thang;
        private ComboBox cbb_ngay;
        private Button btn_tim;
        private Label label3;
        private TextBox tb_result;
        private Button btn_xoa;
        private Button btn_thoat;
    }
}