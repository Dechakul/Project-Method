namespace WinForms.Methods
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
            MessageBox.Show("à¸¢à¸´à¸™à¸”à¸µà¸•à¹‰à¸­à¸™à¸£à¸±à¸š", "à¹‚à¸›à¸£à¸¡à¹à¸à¸£à¸¡à¸—à¸”à¸ªà¸­à¸šà¸„à¸³à¸™à¸§à¸“ BMI");
            clearFrom();
        }

        private void clearFrom()
        {
            txtAge.TextAlign = HorizontalAlignment.Left;
            txtWeight.TextAlign = HorizontalAlignment.Left;
            txtHeight.TextAlign = HorizontalAlignment.Left;
=======
            MessageBox.Show("ÂÔ¹´ÕµéÍ¹ÃÑº", "â»Ãá¡ÃÁ·´ÊÍº¤ÇÒÁÍéÇ¹¼ÍÁ");
            clearForm();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //»ØèÁ "¤Ó¹Ç³ BMI"
            //input  ÃÑº¤èÒ Textbox
            string name = txtName.Text;
            int age = Convert.ToInt32(txtAge.Text);
            //1    double height = Convert.ToDouble(txtHeight.Text);
            //1    double weight = Convert.ToDouble(txtWeight.Text);
            //2  double height = 0;
            //2  if (double.TryParse(txtHeight.Text,out height)==false)
            //2  {
            //2      MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "à¡Ô´¢éÍ¼Ô´¾ÅÒ´");
            //2      return;   //¶éÒ¤èÒã¹ if à»ç¹¨ÃÔ§ ãËé¨º¡ÒÃ·Ó§Ò¹
            //2  }
            //2  double weight = 0;
            //2  if (double.TryParse(txtWeight.Text, out weight) == false)
            //2  {
            //2      MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "à¡Ô´¢éÍ¼Ô´¾ÅÒ´");
            //2      return;   //¶éÒ¤èÒã¹ if à»ç¹¨ÃÔ§ ãËé¨º¡ÒÃ·Ó§Ò¹
            //2  }

            double height = 0;
            double weight = 0;
            if (CheckDouble(txtWeight, txtHeight))     //àÃÕÂ¡ãªé Method áºº¤×¹¤èÒà»ç¹ True/false
            {
                height = Convert.ToDouble(txtWeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
            }


            //Process ¤Ó¹Ç³¤èÒ BMI
            //double bmi = weight / Math.Pow(height / 100, 2);
            double bmi = BMI(height, weight);                   //àÃÕÂ¡ãªémethod BMI

            //Output á»Å¼Å â´Â¹Ó¤èÒ BMI ÁÒà·ÕÂº¡Ñº¤èÒÁÒµÃ°Ò¹
            lblResult.Text = bmi.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtAge.TextAlign = HorizontalAlignment.Right;   //¨Ñ´ªÔ´¢ÇÒ
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
        private void InputDataValid(TextBox name, TextBox age)  //·´ÊÍº¡ÒÃÊè§ Textbox ãËé¡Ñº Method
        {
            if (name.Text.Length != 0)     //.length ¹Ñº¤ÇÒÁÂÒÇ¢Í§ String
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
            //    MessageBox.Show("à¸à¸£à¸­à¸à¸‚à¹‰à¸­à¸¡à¸¹à¸¥à¹„à¸¡à¹ˆà¸–à¸¹à¸à¸•à¹‰à¸­à¸‡", "à¹€à¸à¸´à¸”à¸‚à¹‰à¸­à¸œà¸´à¸”à¸žà¸¥à¸²à¸”");
            //    return;
            //}
            ////double weigth = Convert.ToDouble(txtWeight.Text);
            //double weight = 0;
            //if (double.TryParse(txtWeight.Text, out weight) == false)
            //{
            //    MessageBox.Show("à¸à¸£à¸­à¸à¸‚à¹‰à¸­à¸¡à¸¹à¸¥à¹„à¸¡à¹ˆà¸–à¸¹à¸à¸•à¹‰à¸­à¸‡", "à¹€à¸à¸´à¸”à¸‚à¹‰à¸­à¸œà¸´à¸”à¸žà¸¥à¸²à¸”");
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

        private bool CheckDouble(TextBox txtW, TextBox txtH) //à¸•à¸£à¸§à¸ˆà¸ªà¸­à¸šà¸‚à¹‰à¸­à¸¡à¸¹à¸¥à¸§à¹ˆà¸²à¹€à¸›à¹‡à¸™ Doulble
        {
            double w = 0;
            double h = 0;
            if(double.TryParse(txtW.Text, out w)==false || double.TryParse(txtW.Text, out h) == false)
            {
                MessageBox.Show("à¸à¸£à¸­à¸à¸‚à¹‰à¸­à¸¡à¸¹à¸¥à¹„à¸¡à¹ˆà¸–à¸¹à¸à¸•à¹‰à¸­à¸‡", "à¹€à¸à¸´à¸”à¸‚à¹‰à¸­à¸œà¸´à¸”à¸žà¸¥à¸²à¸”");
=======
        private double BMI(double h, double w)    //¤Ó¹Ç³¤èÒ bmi Êè§¤èÒà¢éÒÁÒ 2 ¤èÒ¤×Í¹éÓË¹Ñ¡áÅÐÊèÇ¹ÊÙ§
        {
            double bmi = w / Math.Pow(h / 100, 2);
            return bmi;
            //return w / Math.Pow(h / 100, 2);
        }

        private bool CheckDouble(TextBox txtW, TextBox txtH)   //µÃÇ¨ÊÍº¢éÍÁÙÅÇèÒà»ç¹ Double ËÃ×ÍäÁè
        {
            double w = 0;
            double h = 0;
            if((double.TryParse(txtW.Text,out w)==false)|| (double.TryParse(txtW.Text, out h) == false))
            {
                MessageBox.Show("¡ÃÍ¡¢éÍÁÙÅäÁè¶Ù¡µéÍ§", "à¡Ô´¢éÍ¼Ô´¾ÅÒ´");
>>>>>>> a3bd6ed35f305bc6e4706be448ad0ef16e0a463c
                return false;
            }
            return true;
        }
    }

}
