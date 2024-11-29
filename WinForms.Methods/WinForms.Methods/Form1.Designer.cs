namespace WinForms.Methods
{
    partial class frmBMI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtWeight = new TextBox();
            label4 = new Label();
            txtAge = new TextBox();
            label5 = new Label();
            txtHeight = new TextBox();
            lblResult = new Label();
            btnBMI = new Button();
<<<<<<< HEAD
            btnClear = new Button();
=======
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnClear = new Button();
            label12 = new Label();
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(155, 9);
            label1.Name = "label1";
            label1.Size = new Size(324, 45);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมคำนวณค่า BMI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 271);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "น้ำหนัก (kg)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 114);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "ชื่อ-นามสกุล";
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(339, 29);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(155, 271);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(128, 29);
            txtWeight.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 173);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 2;
            label4.Text = "อายุ";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(155, 167);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(128, 29);
            txtAge.TabIndex = 2;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 225);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 2;
            label5.Text = "ส่วนสูง (cm)";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(155, 219);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(128, 29);
            txtHeight.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 192);
            lblResult.Font = new Font("Segoe UI", 24F);
            lblResult.ForeColor = Color.Green;
            lblResult.Location = new Point(145, 341);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(615, 224);
            lblResult.TabIndex = 5;
            lblResult.Text = "...";
            // 
            // btnBMI
            // 
<<<<<<< HEAD
            btnBMI.Location = new Point(615, 108);
=======
            btnBMI.Location = new Point(547, 90);
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(197, 120);
            btnBMI.TabIndex = 5;
            btnBMI.Text = "ค่า BMI";
            btnBMI.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            btnBMI.Click += btnBMI_Click_1;
=======
            btnBMI.Click += btnBMI_Click;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            // 
            // btnClear
            // 
<<<<<<< HEAD
            btnClear.Location = new Point(685, 271);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 47);
            btnClear.TabIndex = 7;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
=======
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(668, 182);
            label7.Name = "label7";
            label7.Size = new Size(76, 28);
            label7.TabIndex = 6;
            label7.Text = "btnBMI";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(674, 352);
            label8.Name = "label8";
            label8.Size = new Size(86, 28);
            label8.TabIndex = 6;
            label8.Text = "lblResult";
            label8.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(399, 145);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 6;
            label6.Text = "txtName";
            label6.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(289, 173);
            label9.Name = "label9";
            label9.Size = new Size(70, 28);
            label9.TabIndex = 6;
            label9.Text = "txtAge";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(289, 222);
            label10.Name = "label10";
            label10.Size = new Size(94, 28);
            label10.TabIndex = 6;
            label10.Text = "txtHeight";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(289, 271);
            label11.Name = "label11";
            label11.Size = new Size(98, 28);
            label11.TabIndex = 6;
            label11.Text = "txtWeight";
            label11.Visible = false;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            // 
            // btnClear
            // 
            btnClear.Location = new Point(547, 237);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 45);
            btnClear.TabIndex = 7;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(668, 271);
            label12.Name = "label12";
            label12.Size = new Size(86, 28);
            label12.TabIndex = 6;
            label12.Text = "btnClear";
            label12.Visible = false;
            // 
            // frmBMI
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(868, 593);
            Controls.Add(btnClear);
=======
            ClientSize = new Size(772, 675);
            Controls.Add(label12);
            Controls.Add(btnClear);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label7);
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            Controls.Add(btnBMI);
            Controls.Add(lblResult);
            Controls.Add(txtWeight);
            Controls.Add(txtHeight);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmBMI";
            Text = "โปรแกรมคำนวณค่า BMI  (เรื่อง Method/Function)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtAge;
        private Label label5;
        private TextBox txtHeight;
        private Label lblResult;
        private Button btnBMI;
<<<<<<< HEAD
        private Button btnClear;
=======
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnClear;
        private Label label12;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
    }
}
