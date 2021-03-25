using System;
using squareCalc;

namespace TestApp
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите радиус круга, либо длины 3 сторон треугольника через пробел");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            if (inputArr.Length == 1)
            {
                squareCalc.Calc calc = new Calc(double.Parse(inputArr[0]));
                calc.Circle();
            }
            else if (inputArr.Length == 3)
            {
                squareCalc.Calc calc = new Calc(double.Parse(inputArr[0]), double.Parse(inputArr[1]), double.Parse(inputArr[2]));
                calc.Triangle();
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}