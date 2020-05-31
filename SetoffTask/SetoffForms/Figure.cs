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
    public partial class Figure : Form
    {
        public Figure()
        {
            InitializeComponent();
        }

        public class Point
        {
            public int coordX, coordY;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (InputNums(tbAX.Text, tbAY.Text, tbBX.Text, tbBY.Text, tbCX.Text, tbCY.Text, tbDX.Text, tbDY.Text) == true)
            {
                Point pointA = new Point();
                Point pointB = new Point();
                Point pointC = new Point();
                Point pointD = new Point();
                pointA.coordX = Convert.ToInt32(tbAX.Text);
                pointA.coordY = Convert.ToInt32(tbAY.Text);
                pointB.coordX = Convert.ToInt32(tbBX.Text);
                pointB.coordY = Convert.ToInt32(tbBY.Text);
                pointC.coordX = Convert.ToInt32(tbCX.Text);
                pointC.coordY = Convert.ToInt32(tbCY.Text);
                pointD.coordX = Convert.ToInt32(tbDX.Text);
                pointD.coordY = Convert.ToInt32(tbDY.Text);

                double sideAB = Math.Round(Math.Sqrt(Math.Pow((pointB.coordX - pointA.coordX), 2) + Math.Pow((pointB.coordY - pointA.coordY), 2)), 2);
                double sideAD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointA.coordX), 2) + Math.Pow((pointD.coordY - pointA.coordY), 2)), 2);
                double sideBC = Math.Round(Math.Sqrt(Math.Pow((pointC.coordX - pointB.coordX), 2) + Math.Pow((pointC.coordY - pointB.coordY), 2)), 2);
                double sideCD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointC.coordX), 2) + Math.Pow((pointD.coordY - pointC.coordY), 2)), 2);

                double halfPerimeter = (sideAB + sideBC + sideCD + sideAD) / 2;
                double square = Math.Round(Math.Sqrt((halfPerimeter - sideAB) * (halfPerimeter - sideBC) * (halfPerimeter - sideCD) * (halfPerimeter - sideAD)), 2);
                tbSqure.Text = square.ToString();
            }
            else
                MessageBox.Show("Вам нужно ввести целое число");

        }

        public static bool InputNums(string txtBox1, string txtBox2, string txtBox3, string txtBox4, string txtBox5, string txtBox6, string txtBox7, string txtBox8)
        {

            bool isNum1 = int.TryParse(txtBox1, out int st1);
            bool isNum2 = int.TryParse(txtBox2, out int st2);
            bool isNum3 = int.TryParse(txtBox3, out int st3);
            bool isNum4 = int.TryParse(txtBox4, out int st4);
            bool isNum5 = int.TryParse(txtBox5, out int st5);
            bool isNum6 = int.TryParse(txtBox6, out int st6);
            bool isNum7 = int.TryParse(txtBox7, out int st7);
            bool isNum8 = int.TryParse(txtBox8, out int st8);

            if (isNum1 && isNum2 && isNum3 && isNum4 && isNum5 && isNum6 && isNum7 && isNum8 == true)
                return true;
            else
                return false;

        }
    }
}
