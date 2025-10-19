namespace TH1
{
    partial class Bai7
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
            btn_result = new Button();
            tb_nhap = new TextBox();
            tb_result = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_trungbinh = new TextBox();
            tb_max = new TextBox();
            tb_min = new TextBox();
            tb_dau = new TextBox();
            tb_kodau = new TextBox();
            tb_xeploai = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(120, 9);
            label1.Name = "label1";
            label1.Size = new Size(428, 50);
            label1.TabIndex = 0;
            label1.Text = "Nhập mảng (ngăn cách các phần từ bằng dấu ',' ; \n Ví dụ: Nguyễn Thị A, 7.5, 5, 8, 10, 9,10, 8.5, 9, 10)";
            // 
            // btn_result
            // 
            btn_result.Font = new Font("Segoe UI", 11F);
            btn_result.Location = new Point(650, 69);
            btn_result.Name = "btn_result";
            btn_result.Size = new Size(130, 32);
            btn_result.TabIndex = 1;
            btn_result.Text = "Xác nhận";
            btn_result.UseVisualStyleBackColor = true;
            btn_result.Click += btn_result_Click;
            // 
            // tb_nhap
            // 
            tb_nhap.Font = new Font("Segoe UI", 11F);
            tb_nhap.Location = new Point(38, 69);
            tb_nhap.Name = "tb_nhap";
            tb_nhap.Size = new Size(588, 32);
            tb_nhap.TabIndex = 2;
            // 
            // tb_result
            // 
            tb_result.BackColor = SystemColors.Info;
            tb_result.BorderStyle = BorderStyle.FixedSingle;
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(38, 114);
            tb_result.Multiline = true;
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(379, 241);
            tb_result.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(465, 111);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 4;
            label2.Text = "Điểm trung bình";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(465, 154);
            label3.Name = "label3";
            label3.Size = new Size(138, 28);
            label3.TabIndex = 5;
            label3.Text = "Điểm cao nhất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(465, 199);
            label4.Name = "label4";
            label4.Size = new Size(147, 28);
            label4.TabIndex = 6;
            label4.Text = "Điểm thấp nhất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(465, 244);
            label5.Name = "label5";
            label5.Size = new Size(118, 28);
            label5.TabIndex = 7;
            label5.Text = "Số môn đậu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(465, 290);
            label6.Name = "label6";
            label6.Size = new Size(179, 28);
            label6.TabIndex = 8;
            label6.Text = "Số môn không đậu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(465, 338);
            label7.Name = "label7";
            label7.Size = new Size(83, 28);
            label7.TabIndex = 9;
            label7.Text = "Xếp loại";
            // 
            // tb_trungbinh
            // 
            tb_trungbinh.Font = new Font("Segoe UI", 12F);
            tb_trungbinh.Location = new Point(655, 104);
            tb_trungbinh.Name = "tb_trungbinh";
            tb_trungbinh.ReadOnly = true;
            tb_trungbinh.Size = new Size(125, 34);
            tb_trungbinh.TabIndex = 10;
            // 
            // tb_max
            // 
            tb_max.Font = new Font("Segoe UI", 12F);
            tb_max.Location = new Point(655, 147);
            tb_max.Name = "tb_max";
            tb_max.ReadOnly = true;
            tb_max.Size = new Size(125, 34);
            tb_max.TabIndex = 11;
            // 
            // tb_min
            // 
            tb_min.Font = new Font("Segoe UI", 12F);
            tb_min.Location = new Point(655, 192);
            tb_min.Name = "tb_min";
            tb_min.ReadOnly = true;
            tb_min.Size = new Size(125, 34);
            tb_min.TabIndex = 12;
            // 
            // tb_dau
            // 
            tb_dau.Font = new Font("Segoe UI", 12F);
            tb_dau.Location = new Point(655, 237);
            tb_dau.Name = "tb_dau";
            tb_dau.ReadOnly = true;
            tb_dau.Size = new Size(125, 34);
            tb_dau.TabIndex = 13;
            // 
            // tb_kodau
            // 
            tb_kodau.Font = new Font("Segoe UI", 12F);
            tb_kodau.Location = new Point(655, 283);
            tb_kodau.Name = "tb_kodau";
            tb_kodau.ReadOnly = true;
            tb_kodau.Size = new Size(125, 34);
            tb_kodau.TabIndex = 14;
            // 
            // tb_xeploai
            // 
            tb_xeploai.Font = new Font("Segoe UI", 12F);
            tb_xeploai.Location = new Point(655, 331);
            tb_xeploai.Name = "tb_xeploai";
            tb_xeploai.ReadOnly = true;
            tb_xeploai.Size = new Size(125, 34);
            tb_xeploai.TabIndex = 15;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_xeploai);
            Controls.Add(tb_kodau);
            Controls.Add(tb_dau);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(tb_trungbinh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_result);
            Controls.Add(tb_nhap);
            Controls.Add(btn_result);
            Controls.Add(label1);
            Name = "Bai7";
            Text = "Bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_result;
        private TextBox tb_nhap;
        private TextBox tb_result;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_trungbinh;
        private TextBox tb_max;
        private TextBox tb_min;
        private TextBox tb_dau;
        private TextBox tb_kodau;
        private TextBox tb_xeploai;
    }
}