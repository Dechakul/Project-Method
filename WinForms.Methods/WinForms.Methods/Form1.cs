﻿namespace WinForms.Methods
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            MessageBox.Show("ยินดีต้อนรับ", "โปรมแกรมทดสอบคำนวณ BMI");
            clearFrom();
        }

        private void clearFrom()
        {
            txtAge.TextAlign = HorizontalAlignment.Left;
            txtWeight.TextAlign = HorizontalAlignment.Left;
            txtHeight.TextAlign = HorizontalAlignment.Left;
=======
            MessageBox.Show("�Թ�յ�͹�Ѻ", "��������ͺ������ǹ���");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //���� "�ӹǳ BMI"
            //input  �Ѻ��� Textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1    double height = Convert.ToDouble(txtHeight.Text);
            //1    double weight = Convert.ToDouble(txtWeight.Text);
            //2  double height = 0;
            //2  if (double.TryParse(txtHeight.Text,out height)==false)
            //2  {
            //2      MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2      return;   //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2  }
            //2  double weight = 0;
            //2  if (double.TryParse(txtWeight.Text, out weight) == false)
            //2  {
            //2      MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
            //2      return;   //��Ҥ��� if �繨�ԧ ��騺��÷ӧҹ
            //2  }

            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))     //���¡�� Method Ẻ�׹����� True/false
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }


            //Process �ӹǳ��� BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);                   //���¡��method BMI

            //Output �ż� �¹Ӥ�� BMI ����º�Ѻ����ҵðҹ
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;   //�Ѵ�Դ���
            txtHeight.TextAlign = HorizontalAlignment.Right;
            txtWeight.TextAlign = HorizontalAlignment.Right;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            txtName.Text = "";
            txtAge.Text = "0";
            txtHeight.Text = "0";
            txtWeight.Text = "0";
            txtName.Focus();

        }

<<<<<<< HEAD
        private void InputDataValid(TextBox name, TextBox age)
        {
            if (name.Text.Length != 0)
            {
                name.ForeColor = Color.DarkBlue;
            }
            else
            {
                name.ForeColor = Color.Red;
            }
            if (Convert.ToInt32(age.Text) != 0)
            {
                age.ForeColor = Color.DarkRed;
=======
        private void InputDataValid(TextBox name, TextBox age)  //���ͺ����� Textbox ���Ѻ Method
        {
            if (name.Text.Length != 0)     //.length �Ѻ������Ǣͧ String
            {
                name.ForeColor = Color.DarkGreen;
            }
            else
            {
                name.ForeColor = Color.Black;
            }
            if (Convert.ToInt32(age.Text) > 0)
            {
                age.ForeColor = Color.DarkGreen;
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
            }
            else
            {
                age.ForeColor = Color.Black;
            }
        }

<<<<<<< HEAD
        private void btnBMI_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //double heigth = Convert.ToDouble(txtHeight.Text);
            //double height = 0;
            //if (double.TryParse(txtHeight.Text, out height)==false)
            //{
            //    MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //    return;
            //}
            ////double weigth = Convert.ToDouble(txtWeight.Text);
            //double weight = 0;
            //if (double.TryParse(txtWeight.Text, out weight) == false)
            //{
            //    MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
            //    return;
            //}

            double height = 0;
            double weight = 0;

            if (CheckDouble(txtWeight, txtHeight))
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }


            //double bmi = weigth / Math.Pow(heigth / 100, 2);
            double bmi = BMI(height, weight);

            lblResult.Text = bmi.ToString();
        }

=======
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            InputDataValid(txtName, txtAge);
        }
<<<<<<< HEAD

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFrom();
        }

        private double BMI(double h, double w)
        {
            double bmi = w/Math.Pow(h/100, 2);
            return bmi;
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH) //ตรวจสอบข้อมูลว่าเป็น Doulble
        {
            double w = 0;
            double h = 0;
            if(double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text, out h) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "เกิดข้อผิดพลาด");
=======
        private double BMI(double h, double w)    //�ӹǳ��� bmi �觤������� 2 ��Ҥ�͹��˹ѡ�����ǹ�٧
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2);
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)   //��Ǩ�ͺ����������� Double �������
        {
            double w = 0;
            double h = 0;
            if((double.TryParse(txtW.Text,out w)==false)|| (double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("��͡���������١��ͧ", "�Դ��ͼԴ��Ҵ");
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
                return false;
            }
            return true;
        }
    }

}
