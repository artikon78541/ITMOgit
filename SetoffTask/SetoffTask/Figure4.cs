using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SetoffTask
{
    class Figure
    {
        public Point pointA;
        public Point pointB;
        public Point pointC;
        public Point pointD;


        public Figure(Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            pointA = firstPoint;
            pointB = secondPoint;
            pointC = thirdPoint;
            pointD = fourthPoint;
        }


        public void CalculateSides()
        {

            double sideAB = Math.Round(Math.Sqrt(Math.Pow((pointB.coordX - pointA.coordX), 2) + Math.Pow((pointB.coordY - pointA.coordY), 2)), 2);
            double sideAD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointA.coordX), 2) + Math.Pow((pointD.coordY - pointA.coordY), 2)), 2);
            double sideBC = Math.Round(Math.Sqrt(Math.Pow((pointC.coordX - pointB.coordX), 2) + Math.Pow((pointC.coordY - pointB.coordY), 2)), 2);
            double sideCD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointC.coordX), 2) + Math.Pow((pointD.coordY - pointC.coordY), 2)), 2);

            Console.WriteLine("Длина отрезка AB - " + sideAB);
            Console.WriteLine("Длина отрезка BC - " + sideBC);
            Console.WriteLine("Длина отрезка CD - " + sideCD);
            Console.WriteLine("Длина отрезка AD - " + sideAD);
        }
        public double CalculateArea()
        {
            double sideAB = Math.Round(Math.Sqrt(Math.Pow((pointB.coordX - pointA.coordX), 2) + Math.Pow((pointB.coordY - pointA.coordY), 2)),2);
            double sideAD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointA.coordX), 2) + Math.Pow((pointD.coordY - pointA.coordY), 2)),2);
            double sideBC = Math.Round(Math.Sqrt(Math.Pow((pointC.coordX - pointB.coordX), 2) + Math.Pow((pointC.coordY - pointB.coordY), 2)),2);
            double sideCD = Math.Round(Math.Sqrt(Math.Pow((pointD.coordX - pointC.coordX), 2) + Math.Pow((pointD.coordY - pointC.coordY), 2)),2);
            double halfPerimeter = (sideAB + sideBC + sideCD + sideAD) / 2;
            double square = Math.Round(Math.Sqrt((halfPerimeter - sideAB) * (halfPerimeter - sideBC) * (halfPerimeter - sideCD) * (halfPerimeter - sideAD)),2);
            return square;
        }



    }




}
