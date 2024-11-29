namespace WinForms.Methods
{
    partial class Form2
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
            txtResult = new TextBox();
            button1 = new Button();
<<<<<<< HEAD
=======
            label6 = new Label();
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            SuspendLayout();
            // 
            // txtResult
            // 
<<<<<<< HEAD
            txtResult.Location = new Point(46, 39);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(276, 369);
=======
            txtResult.Location = new Point(28, 36);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(339, 460);
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            txtResult.TabIndex = 0;
            // 
            // button1
            // 
<<<<<<< HEAD
            button1.Location = new Point(380, 39);
            button1.Name = "button1";
            button1.Size = new Size(97, 42);
            button1.TabIndex = 1;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Name = "Form2";
            Text = "Form2";
=======
            button1.Location = new Point(435, 36);
            button1.Name = "button1";
            button1.Size = new Size(137, 54);
            button1.TabIndex = 1;
            button1.Text = "GO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(267, 458);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 7;
            label6.Text = "txtResult";
            label6.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 536);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtResult);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "Method/Function (Using parameters)";
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button button1;
<<<<<<< HEAD
=======
        private Label label6;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
    }
}