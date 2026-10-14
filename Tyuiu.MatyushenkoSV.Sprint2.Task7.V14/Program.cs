using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task7.V14.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Матюшенко С. В. | Вариант #14";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #2                                                               *");
            Console.WriteLine("* Тема: Нахождение точки в заштрихованной области                         *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает исходные вещественные данные    *");
            Console.WriteLine("* и вычисляет, находится ли точка с координатами X, Y                     *");
            Console.WriteLine("* в заштрихованной области.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
