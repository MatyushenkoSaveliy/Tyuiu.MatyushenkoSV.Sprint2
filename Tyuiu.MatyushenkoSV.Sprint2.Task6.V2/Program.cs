using System;
using Tyuiu.MatyushenkoSV.Sprint2.Task6.V2.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Матюшенко С. В. | Вариант #2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* СПРИНТ #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* По данному месяцу определить, в какую пору года попадает этот месяц.    *");
            Console.WriteLine("* С использованием сокращенной формы оператора switch.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер месяца: ");
            int numMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res;

            if ((numMonth < 1) || (numMonth > 12))
            {
                res = "Введенно неверное значение!";
            }
            else
            {
                res = "Пора года: " + ds.FindSeasonName(numMonth);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
