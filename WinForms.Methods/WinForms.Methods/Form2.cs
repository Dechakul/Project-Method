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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtResult.Text = Triangle(5);
            //txtResult.Text = Triangle("A", 9);
            //txtResult.Text = Triangle("B");
<<<<<<< HEAD
            txtResult.Text = Triangle();
=======
            txtResult.Text = Triangle("R");
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        }

        string Triangle(int size)
        {
<<<<<<< HEAD
            string txt_result = "";
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < i; j++)
=======
            string txt_result="";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
<<<<<<< HEAD
            return txt_result;  
        }

        string Triangle(string letter,int size)
=======
            return txt_result;
        }

        string Triangle(string letter, int size=5)
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        {
            string txt_result = "";
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

<<<<<<< HEAD
        string Triangle(string letter)
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += letter;
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }

=======
        //string Triangle(string letter)
        //{
        //    string txt_result = "";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int j = 0; j < i; j++)
        //        {
        //            txt_result += letter;
        //        }
        //        txt_result += Environment.NewLine;
        //    }
        //    return txt_result;
        //}
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        string Triangle()
        {
            string txt_result = "";
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    txt_result += "*";
                }
                txt_result += Environment.NewLine;
            }
            return txt_result;
        }
<<<<<<< HEAD
=======

>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
    }
}
