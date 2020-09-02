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
    public partial class Intersection : Form
    {
        public Intersection()
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
                Point firstPoint = new Point();
                Point secondPoint = new Point();
                Point thirdPoint = new Point();
                Point fourthPoint = new Point();
                firstPoint.coordX = Convert.ToInt32(tbAX.Text);
                firstPoint.coordY = Convert.ToInt32(tbAY.Text);
                secondPoint.coordX = Convert.ToInt32(tbBX.Text);
                secondPoint.coordY = Convert.ToInt32(tbBY.Text);
                thirdPoint.coordX = Convert.ToInt32(tbCX.Text);
                thirdPoint.coordY = Convert.ToInt32(tbCY.Text);
                fourthPoint.coordX = Convert.ToInt32(tbDX.Text);
                fourthPoint.coordY = Convert.ToInt32(tbDY.Text);

                bool x = Intersection.IntersectLines(firstPoint, secondPoint, thirdPoint, fourthPoint);
                if (x)
                    tbResult.Text = "Данные отрезки пересекаются";
                else
                    tbResult.Text = "Данные отрезки не пересекаются";

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

            if (isNum1 && isNum2 && isNum3 && isNum4 && isNum5 && isNum6 && isNum7 && isNum8== true)
                return true;
            else
                return false;

        }

        public static int FindTriangleArea(Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return (secondPoint.coordX - firstPoint.coordX) * (thirdPoint.coordY - firstPoint.coordY) - (secondPoint.coordY - firstPoint.coordY) * (thirdPoint.coordX - firstPoint.coordX);
        }

        static bool IntersectionTemp(int firstCoord, int secondCoord, int thirdCoord, int fourthCoord)
        {
            if (firstCoord > secondCoord)
            {
                int temp = secondCoord;
                secondCoord = firstCoord;
                firstCoord = temp;
            }
            if (thirdCoord > fourthCoord)
            {
                int temp = fourthCoord;
                fourthCoord = thirdCoord;
                thirdCoord = temp;
            }

            return Math.Max(firstCoord, thirdCoord) <= Math.Min(secondCoord, fourthCoord);
        }

        public static bool IntersectLines(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            return IntersectionTemp(firstPoint.coordX, secondPoint.coordX, thirdPoint.coordX, fourthPoint.coordX) && IntersectionTemp(firstPoint.coordY, secondPoint.coordY, thirdPoint.coordY, fourthPoint.coordY) && FindTriangleArea(firstPoint, secondPoint, thirdPoint) * FindTriangleArea(firstPoint, secondPoint, fourthPoint) <= 0 && FindTriangleArea(thirdPoint, fourthPoint, firstPoint) * FindTriangleArea(thirdPoint, fourthPoint, secondPoint) <= 0;
        }

    }
}
