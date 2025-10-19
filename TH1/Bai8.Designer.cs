namespace TH1
{
    partial class Bai8
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
            tb_monan = new TextBox();
            tb_list = new TextBox();
            btn_them = new Button();
            btn_tim = new Button();
            btn_xoa = new Button();
            btn_thoat = new Button();
            label2 = new Label();
            tb_result = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(10, 33);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên món ăn";
            // 
            // tb_monan
            // 
            tb_monan.Font = new Font("Segoe UI", 14F);
            tb_monan.Location = new Point(219, 26);
            tb_monan.Name = "tb_monan";
            tb_monan.Size = new Size(247, 39);
            tb_monan.TabIndex = 1;
            // 
            // tb_list
            // 
            tb_list.BackColor = SystemColors.ControlLightLight;
            tb_list.Font = new Font("Segoe UI", 14F);
            tb_list.Location = new Point(474, 26);
            tb_list.Multiline = true;
            tb_list.Name = "tb_list";
            tb_list.ReadOnly = true;
            tb_list.Size = new Size(314, 187);
            tb_list.TabIndex = 2;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 14F);
            btn_them.Location = new Point(212, 89);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(166, 57);
            btn_them.TabIndex = 3;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_tim
            // 
            btn_tim.Font = new Font("Segoe UI", 14F);
            btn_tim.Location = new Point(40, 89);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(166, 57);
            btn_tim.TabIndex = 4;
            btn_tim.Text = "Tìm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 14F);
            btn_xoa.Location = new Point(40, 152);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(166, 57);
            btn_xoa.TabIndex = 5;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 14F);
            btn_thoat.Location = new Point(212, 152);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(166, 57);
            btn_thoat.TabIndex = 6;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(243, 224);
            label2.Name = "label2";
            label2.Size = new Size(223, 32);
            label2.TabIndex = 7;
            label2.Text = "Món ăn hôm nay là";
            // 
            // tb_result
            // 
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(153, 280);
            tb_result.Name = "tb_result";
            tb_result.Size = new Size(401, 39);
            tb_result.TabIndex = 8;
            // 
            // Bai8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_result);
            Controls.Add(label2);
            Controls.Add(btn_thoat);
            Controls.Add(btn_xoa);
            Controls.Add(btn_tim);
            Controls.Add(btn_them);
            Controls.Add(tb_list);
            Controls.Add(tb_monan);
            Controls.Add(label1);
            Name = "Bai8";
            Text = "Bai8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_monan;
        private TextBox tb_list;
        private Button btn_them;
        private Button btn_tim;
        private Button btn_xoa;
        private Button btn_thoat;
        private Label label2;
        private TextBox tb_result;
    }
}