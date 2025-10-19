namespace TH1
{
    partial class Bai2
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
            btn_doc_bai2 = new Button();
            btn_xoa_bai2 = new Button();
            btn_thoat_bai2 = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_num = new TextBox();
            tb_result = new TextBox();
            SuspendLayout();
            // 
            // btn_doc_bai2
            // 
            btn_doc_bai2.Location = new Point(637, 111);
            btn_doc_bai2.Name = "btn_doc_bai2";
            btn_doc_bai2.Size = new Size(123, 60);
            btn_doc_bai2.TabIndex = 0;
            btn_doc_bai2.Text = "Đọc";
            btn_doc_bai2.UseVisualStyleBackColor = true;
            btn_doc_bai2.Click += btn_doc_bai2_Click;
            // 
            // btn_xoa_bai2
            // 
            btn_xoa_bai2.Location = new Point(637, 187);
            btn_xoa_bai2.Name = "btn_xoa_bai2";
            btn_xoa_bai2.Size = new Size(123, 60);
            btn_xoa_bai2.TabIndex = 1;
            btn_xoa_bai2.Text = "Xóa";
            btn_xoa_bai2.UseVisualStyleBackColor = true;
            btn_xoa_bai2.Click += btn_xoa_bai2_Click;
            // 
            // btn_thoat_bai2
            // 
            btn_thoat_bai2.Location = new Point(637, 264);
            btn_thoat_bai2.Name = "btn_thoat_bai2";
            btn_thoat_bai2.Size = new Size(123, 60);
            btn_thoat_bai2.TabIndex = 2;
            btn_thoat_bai2.Text = "Thoát";
            btn_thoat_bai2.UseVisualStyleBackColor = true;
            btn_thoat_bai2.Click += btn_thoat_bai2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(22, 120);
            label1.Name = "label1";
            label1.Size = new Size(353, 32);
            label1.TabIndex = 3;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(22, 234);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 4;
            label2.Text = "Kết quả";
            // 
            // tb_num
            // 
            tb_num.Font = new Font("Segoe UI", 14F);
            tb_num.Location = new Point(402, 117);
            tb_num.Name = "tb_num";
            tb_num.Size = new Size(154, 39);
            tb_num.TabIndex = 5;
            // 
            // tb_result
            // 
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(145, 227);
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(411, 39);
            tb_result.TabIndex = 6;
            // 
            // Bai2
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
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_doc_bai2;
        private Button btn_xoa_bai2;
        private Button btn_thoat_bai2;
        private Label label1;
        private Label label2;
        private TextBox tb_num;
        private TextBox tb_result;
    }
}