namespace TH1
{
    partial class Bai0
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
            tb_result = new TextBox();
            tinh = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_num2 = new TextBox();
            tb_num1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(413, 32);
            label1.Name = "label1";
            label1.Size = new Size(261, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhập 2 số nguyên";
            // 
            // tb_result
            // 
            tb_result.Font = new Font("Segoe UI", 14F);
            tb_result.Location = new Point(427, 330);
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(261, 39);
            tb_result.TabIndex = 1;
            // 
            // tinh
            // 
            tinh.Font = new Font("Segoe UI", 14F);
            tinh.Location = new Point(314, 264);
            tinh.Name = "tinh";
            tinh.Size = new Size(129, 46);
            tinh.TabIndex = 2;
            tinh.Text = "Tính";
            tinh.UseVisualStyleBackColor = true;
            tinh.Click += tinh_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(257, 330);
            label2.Name = "label2";
            label2.Size = new Size(87, 41);
            label2.TabIndex = 3;
            label2.Text = "Tổng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(83, 194);
            label3.Name = "label3";
            label3.Size = new Size(261, 41);
            label3.TabIndex = 4;
            label3.Text = "Nhập 2 số nguyên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(83, 96);
            label4.Name = "label4";
            label4.Size = new Size(261, 41);
            label4.TabIndex = 5;
            label4.Text = "Nhập 2 số nguyên";
            // 
            // tb_num2
            // 
            tb_num2.Font = new Font("Segoe UI", 13F);
            tb_num2.Location = new Point(427, 194);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(261, 36);
            tb_num2.TabIndex = 6;
            // 
            // tb_num1
            // 
            tb_num1.Font = new Font("Segoe UI", 13F);
            tb_num1.Location = new Point(427, 110);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(261, 36);
            tb_num1.TabIndex = 7;
            tb_num1.TextChanged += textBox3_TextChanged;
            // 
            // Bai0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_num1);
            Controls.Add(tb_num2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tinh);
            Controls.Add(tb_result);
            Controls.Add(label1);
            Name = "Bai0";
            Text = "Bai0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_result;
        private Button tinh;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_num2;
        private TextBox tb_num1;
    }
}