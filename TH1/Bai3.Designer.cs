namespace TH1
{
    partial class Bai3
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
            tb_result = new TextBox();
            tb_num = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_thoat_bai2 = new Button();
            btn_xoa_bai2 = new Button();
            btn_doc_bai2 = new Button();
            SuspendLayout();
            // 
            // tb_result
            // 
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(155, 297);
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(633, 39);
            tb_result.TabIndex = 13;
            // 
            // tb_num
            // 
            tb_num.Font = new Font("Segoe UI", 14F);
            tb_num.Location = new Point(552, 78);
            tb_num.Name = "tb_num";
            tb_num.Size = new Size(236, 39);
            tb_num.TabIndex = 12;
            tb_num.TextChanged += tb_num_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(32, 304);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 11;
            label2.Text = "Kết quả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(523, 32);
            label1.TabIndex = 10;
            label1.Text = "Nhập vào số nguyên dương có tối đa 12 chữ số";
            // 
            // btn_thoat_bai2
            // 
            btn_thoat_bai2.Location = new Point(616, 188);
            btn_thoat_bai2.Name = "btn_thoat_bai2";
            btn_thoat_bai2.Size = new Size(123, 60);
            btn_thoat_bai2.TabIndex = 9;
            btn_thoat_bai2.Text = "Thoát";
            btn_thoat_bai2.UseVisualStyleBackColor = true;
            btn_thoat_bai2.Click += btn_thoat_bai2_Click;
            // 
            // btn_xoa_bai2
            // 
            btn_xoa_bai2.Location = new Point(326, 188);
            btn_xoa_bai2.Name = "btn_xoa_bai2";
            btn_xoa_bai2.Size = new Size(123, 60);
            btn_xoa_bai2.TabIndex = 8;
            btn_xoa_bai2.Text = "Xóa";
            btn_xoa_bai2.UseVisualStyleBackColor = true;
            btn_xoa_bai2.Click += btn_xoa_bai2_Click;
            // 
            // btn_doc_bai2
            // 
            btn_doc_bai2.Location = new Point(32, 188);
            btn_doc_bai2.Name = "btn_doc_bai2";
            btn_doc_bai2.Size = new Size(123, 60);
            btn_doc_bai2.TabIndex = 7;
            btn_doc_bai2.Text = "Đọc";
            btn_doc_bai2.UseVisualStyleBackColor = true;
            btn_doc_bai2.Click += btn_doc_bai2_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_result);
            Controls.Add(tb_num);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_thoat_bai2);
            Controls.Add(btn_xoa_bai2);
            Controls.Add(btn_doc_bai2);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_result;
        private TextBox tb_num;
        private Label label2;
        private Label label1;
        private Button btn_thoat_bai2;
        private Button btn_xoa_bai2;
        private Button btn_doc_bai2;
    }
}