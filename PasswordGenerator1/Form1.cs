using System;
using System.Windows.Forms;

namespace PasswordGenerator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getLowChars()
        {
            string chars1 =
                "abdefghijkmnpstuvwxyz";

            chars1 = chars1.Replace("o", "");
            chars1 = chars1.Replace("c", "");
            chars1 = chars1.Replace("q", "");
            return chars1;
        }

        private string getUpChars()
        {
            string chars2 =
            "ABDEFGHJKLMNPQRSTUVWXYZ";

            chars2 = chars2.Replace("O", "");
            chars2 = chars2.Replace("C", "");
            chars2 = chars2.Replace("I", "");

            return chars2;
        }

        private string getNumbers()
        {
            string numbers = "123456789";
            numbers = numbers.Replace("0", "");

            string result = "";
            result = numbers ; 

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string symbolsAndchars = getLowChars();
                if (this.checkBoxNumbers.Checked == true)
                {
                    symbolsAndchars = symbolsAndchars + getNumbers();
                }
                if (checkBoxUpper.Checked == true) 
                {
                    symbolsAndchars = symbolsAndchars + getUpChars();
                }
                int passwordLength = Convert.ToInt32(textBox2.Text);
                string password = "";
                int seed = Convert.ToInt32(Math.Sqrt(DateTime.Now.Ticks));
                Random r = new Random();
                for (int i = 0; i < passwordLength; i++)
                {
                    int j = r.Next(0, symbolsAndchars.Length);
                    string letter = symbolsAndchars[j].ToString();
                    password = password + letter;
                }
                textBox1.Text = password;
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text); 
        }

    }
}
