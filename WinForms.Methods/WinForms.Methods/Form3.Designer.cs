namespace WinForms.Methods
{
    partial class Form3
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
<<<<<<< HEAD
            button1.Location = new Point(108, 12);
            button1.Name = "button1";
            button1.Size = new Size(114, 81);
            button1.TabIndex = 0;
            button1.Text = "BMI";
=======
            button1.Location = new Point(50, 30);
            button1.Name = "button1";
            button1.Size = new Size(224, 98);
            button1.TabIndex = 0;
            button1.Text = "ฟอร์ม BMI";
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
<<<<<<< HEAD
            button2.Location = new Point(108, 157);
            button2.Name = "button2";
            button2.Size = new Size(114, 76);
            button2.TabIndex = 1;
            button2.Text = "Triangle";
=======
            button2.Location = new Point(50, 151);
            button2.Name = "button2";
            button2.Size = new Size(224, 109);
            button2.TabIndex = 1;
            button2.Text = "ฟอร์ม Triangle";
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 256);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 311);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "โปรแกรมหลัก";
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}