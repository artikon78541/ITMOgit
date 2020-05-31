using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SetoffTask
{
    class SetoffTask
    {
        static void Main(string[] args)
        {

            //Нахождение НОД и НОК
            Console.WriteLine("Нахождение наибольшего общего делителя и наименьшего общего кратного");
            Console.WriteLine("Введите первое число");
            int firstNumber = NumsToEnter.InputNums();
            Console.WriteLine("Введите второе число");
            int secondNumber = NumsToEnter.InputNums();
            Console.WriteLine("Наибольший общий делитель - " + NOD.FindNod(firstNumber, secondNumber));
            Console.WriteLine("Наименьшее общее кратное - " + NOK.FindNok(firstNumber, secondNumber));
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();

            //Бинарное возведение в степень
            Console.WriteLine("Бинарное возведение в степень");
            Console.WriteLine("Введите число для возведения в степень");
            int numberToPow = NumsToEnter.InputNums();
            Console.WriteLine("Введите степень числа");
            int power = NumsToEnter.InputNums();
            Console.WriteLine("{0} в степени {1} будет  - " + BinaryPow.CalculatePow(numberToPow, power), numberToPow, power);

            //Проверка двух отрезков на пересечение
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Проверка двух отрезков AB и CD на пересечение");
            Console.WriteLine("Первый отрезок");
            Point pointA = Point.СreatePoint('A');
            Point pointB = Point.СreatePoint('B');
            Console.WriteLine();
            Console.WriteLine("Второй отрезок");
            Point pointC = Point.СreatePoint('C');
            Point pointD = Point.СreatePoint('D');
                        bool x = Intersection.IntersectLines(pointA, pointB, pointC, pointD);
            if (x)
                Console.WriteLine("Данные отрезки пересекаются");
            else
                Console.WriteLine("Данные отрезки не пересекаются");

            //Расчет площади четырехугольника по его координатам
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine();
            Console.WriteLine("Расчет площади и сторон произвольного четырехугольника по его координатам");
            Console.WriteLine("Точка А - левая верхняя вершина четырехугольника");
            Point leftUp = Point.СreatePoint('A');
            Console.WriteLine("Точка B - правая верхняя вершина четырехугольника");
            Point rightUp = Point.СreatePoint('B');
            Console.WriteLine("Точка С - правая нижняя вершина четырехугольника");
            Point rightLow = Point.СreatePoint('C');
            Console.WriteLine("Точка D - левая нижняя вершина четырехугольника");
            Point leftLow = Point.СreatePoint('D');

            Figure figTest = new Figure(leftUp, rightUp, rightLow, leftLow);
            figTest.CalculateSides();
            Console.WriteLine("Площадь четырехугольника - " + figTest.CalculateArea());

        }
    }
}
