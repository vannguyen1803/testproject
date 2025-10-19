namespace TH1
{
    partial class Bai1
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
            label3 = new Label();
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            tb_num3 = new TextBox();
            btn_tim_bai2 = new Button();
            button2 = new Button();
            button3 = new Button();
            max = new Label();
            min = new Label();
            tb_max = new TextBox();
            tb_min = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(1, 58);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 0;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(267, 54);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 1;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(540, 57);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 2;
            label3.Text = "Số thứ ba";
            // 
            // tb_num1
            // 
            tb_num1.Font = new Font("Segoe UI", 14F);
            tb_num1.Location = new Point(146, 51);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(101, 39);
            tb_num1.TabIndex = 3;
            // 
            // tb_num2
            // 
            tb_num2.Font = new Font("Segoe UI", 14F);
            tb_num2.Location = new Point(396, 54);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(101, 39);
            tb_num2.TabIndex = 4;
            // 
            // tb_num3
            // 
            tb_num3.Font = new Font("Segoe UI", 14F);
            tb_num3.Location = new Point(663, 51);
            tb_num3.Name = "tb_num3";
            tb_num3.Size = new Size(101, 39);
            tb_num3.TabIndex = 5;
            // 
            // btn_tim_bai2
            // 
            btn_tim_bai2.Font = new Font("Segoe UI", 14F);
            btn_tim_bai2.Location = new Point(68, 158);
            btn_tim_bai2.Name = "btn_tim_bai2";
            btn_tim_bai2.Size = new Size(138, 65);
            btn_tim_bai2.TabIndex = 6;
            btn_tim_bai2.Text = "Tìm";
            btn_tim_bai2.UseVisualStyleBackColor = true;
            btn_tim_bai2.Click += btn_tim_bai2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(316, 158);
            button2.Name = "button2";
            button2.Size = new Size(138, 65);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(579, 158);
            button3.Name = "button3";
            button3.Size = new Size(138, 65);
            button3.TabIndex = 8;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // max
            // 
            max.AutoSize = true;
            max.Font = new Font("Segoe UI", 14F);
            max.Location = new Point(12, 329);
            max.Name = "max";
            max.Size = new Size(137, 32);
            max.TabIndex = 9;
            max.Text = "Số lớn nhất";
            max.Click += label4_Click;
            // 
            // min
            // 
            min.AutoSize = true;
            min.Font = new Font("Segoe UI", 14F);
            min.Location = new Point(396, 329);
            min.Name = "min";
            min.Size = new Size(145, 32);
            min.TabIndex = 10;
            min.Text = "Số nhỏ nhất";
            // 
            // tb_max
            // 
            tb_max.Font = new Font("Segoe UI", 14F);
            tb_max.Location = new Point(188, 326);
            tb_max.Name = "tb_max";
            tb_max.ReadOnly = true;
            tb_max.Size = new Size(125, 39);
            tb_max.TabIndex = 11;
            // 
            // tb_min
            // 
            tb_min.Font = new Font("Segoe UI", 14F);
            tb_min.Location = new Point(579, 326);
            tb_min.Name = "tb_min";
            tb_min.ReadOnly = true;
            tb_min.Size = new Size(125, 39);
            tb_min.TabIndex = 12;
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tb_min);
            Controls.Add(tb_max);
            Controls.Add(min);
            Controls.Add(max);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_tim_bai2);
            Controls.Add(tb_num3);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_num1;
        private TextBox tb_num2;
        private TextBox tb_num3;
        private Button btn_tim_bai2;
        private Button button2;
        private Button button3;
        private Label max;
        private Label min;
        private TextBox tb_max;
        private TextBox tb_min;
    }
}