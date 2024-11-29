using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form1 form = new Form1();
            form.ShowDialog();
=======
            frmBMI f = new frmBMI();
            f.ShowDialog();
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
<<<<<<< HEAD
            //
=======
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        }
    }
}
