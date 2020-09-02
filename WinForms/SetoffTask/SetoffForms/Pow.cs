using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetoffForms
{
    public partial class Pow : Form
    {
        public Pow()
        {
            InitializeComponent();
        }

        int pow;
        int number;

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputNums(tbNumToPow.Text, tbPow.Text) == true)
            {
                number = Convert.ToInt32(tbNumToPow.Text);
                pow = Convert.ToInt32(tbPow.Text);

                tbResult.Text = CalculatePow(number, pow).ToString();


            }
            else
                MessageBox.Show("Вам нужно ввести целое число");
        }

        public static bool InputNums(string txtBox1, string txtBox2)
        {

            bool isNum1 = int.TryParse(txtBox1, out int st1);
            bool isNum2 = int.TryParse(txtBox2, out int st2);
            if (isNum1 && isNum2 == true)
                return true;
            else
                return false;

        }



        public static int CalculatePow(int number, int pow)
        {
            if (pow == 0)
                return 1;
            else if (pow % 2 == 1)
                return CalculatePow(number, pow - 1) * number;
            else
            {
                int temp = CalculatePow(number, pow / 2);
                return temp * temp;
            }


        }
    }
}
