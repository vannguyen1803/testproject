namespace TH1
{
    partial class Bai5
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
            button2 = new Button();
            button3 = new Button();
            tb_numB = new TextBox();
            tb_result = new TextBox();
            tb_numA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(313, 121);
            button2.Name = "button2";
            button2.Size = new Size(150, 41);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(572, 121);
            button3.Name = "button3";
            button3.Size = new Size(150, 41);
            button3.TabIndex = 2;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tb_numB
            // 
            tb_numB.Font = new Font("Segoe UI", 12F);
            tb_numB.Location = new Point(597, 20);
            tb_numB.Name = "tb_numB";
            tb_numB.Size = new Size(125, 34);
            tb_numB.TabIndex = 5;
            // 
            // tb_result
            // 
            tb_result.BackColor = SystemColors.Menu;
            tb_result.BorderStyle = BorderStyle.FixedSingle;
            tb_result.Location = new Point(21, 200);
            tb_result.Multiline = true;
            tb_result.Name = "tb_result";
            tb_result.ReadOnly = true;
            tb_result.Size = new Size(744, 229);
            tb_result.TabIndex = 6;
            // 
            // tb_numA
            // 
            tb_numA.Font = new Font("Segoe UI", 12F);
            tb_numA.Location = new Point(199, 19);
            tb_numA.Name = "tb_numA";
            tb_numA.Size = new Size(125, 34);
            tb_numA.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(37, 14);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 8;
            label1.Text = "Nhập số A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(413, 14);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 9;
            label2.Text = "Nhập số B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(47, 165);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 10;
            label3.Text = "Kết quả";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            comboBox1.Location = new Point(272, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 36);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(37, 121);
            button1.Name = "button1";
            button1.Size = new Size(198, 41);
            button1.TabIndex = 0;
            button1.Text = "Tính các giá trị";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_numA);
            Controls.Add(tb_result);
            Controls.Add(tb_numB);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private TextBox tb_numB;
        private TextBox tb_result;
        private TextBox tb_numA;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
    }
}