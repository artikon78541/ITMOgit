using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ITMO.SetoffTask
{
    class Point
    {
        public int coordX, coordY;

        public static Point СreatePoint(char namePoint)
        {
            Point created = new Point();
            Console.Write("Введите координаты точки " + namePoint + " через пробел...\n");
            string coordinatesToEnter = Console.ReadLine();
            string[] coordinates = coordinatesToEnter.Split();
            while ((coordinates.Length > 2) || (coordinates.Length < 2) || String.IsNullOrEmpty(coordinates[0]) || String.IsNullOrEmpty(coordinates[1]) || !int.TryParse(coordinates[0], out created.coordX) || !int.TryParse(coordinates[1], out created.coordY))
            {
                Console.Write("Введите 2 целых числа через пробел, где первое число - координата по оси X, а второе - координата по оси Y.\n Пример: 5 -1, где 5 - это координата по оси X, а -1 - координата по оси Y ...\n");
                coordinatesToEnter = Console.ReadLine();
                coordinates = coordinatesToEnter.Split();
            }
            created.coordX = int.Parse(coordinates[0]);
            created.coordY = int.Parse(coordinates[1]);
            return created;
        }
    }

    class Intersection
    {
        public static int FindTriangleArea (Point firstPoint, Point secondPoint, Point thirdPoint)
        {
            return (secondPoint.coordX - firstPoint.coordX) * (thirdPoint.coordY - firstPoint.coordY) - (secondPoint.coordY - firstPoint.coordY) * (thirdPoint.coordX - firstPoint.coordX);
        }

        static bool IntersectionTemp (int firstCoord, int secondCoord, int thirdCoord, int fourthCoord)
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

        public static bool IntersectLines (Point firstPoint, Point secondPoint, Point thirdPoint, Point fourthPoint)
        {
            return IntersectionTemp(firstPoint.coordX, secondPoint.coordX, thirdPoint.coordX, fourthPoint.coordX) && IntersectionTemp(firstPoint.coordY, secondPoint.coordY, thirdPoint.coordY, fourthPoint.coordY) && FindTriangleArea(firstPoint, secondPoint, thirdPoint) * FindTriangleArea(firstPoint, secondPoint, fourthPoint) <= 0 && FindTriangleArea(thirdPoint, fourthPoint, firstPoint) * FindTriangleArea(thirdPoint, fourthPoint, secondPoint) <= 0;
        }
    }
}
