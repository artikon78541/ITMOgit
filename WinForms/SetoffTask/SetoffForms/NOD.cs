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
    public partial class NOD : Form
    {
        public NOD()
        {
            InitializeComponent();
        }

        int firstNum;
        int secNum;


        public static int FindNod(int firstNum, int secNum)
        {
            while (secNum != 0)
            {
                int temp = secNum;
                secNum = firstNum % secNum;
                firstNum = temp;
            }
            return firstNum;
        }
        public static int FindNok(int a, int b)
        {
            return a / NOD.FindNod(a, b) * b;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (InputNums(tbFirstNum.Text, tbSecNum.Text) == true)
            {
                firstNum = Convert.ToInt32(tbFirstNum.Text);
                secNum = Convert.ToInt32(tbSecNum.Text);

                nodTextBox.Text = FindNod(firstNum, secNum).ToString();
                nokTextBox.Text = FindNok(firstNum, secNum).ToString();

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


    }



}
