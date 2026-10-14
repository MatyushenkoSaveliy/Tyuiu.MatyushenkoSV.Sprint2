using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    if (n == 31) { res = "01.02." + g; }
                    else { res = (n + 1).ToString("D2") + ".01." + g; }
                    break;

                case 2:

                    if (n == 29) { res = "01.03." + g; }
                    else { res = (n + 1).ToString("D2") + ".02." + g; }
                    break;

                case 3:
                    if (n == 31) { res = "01.04." + g; }
                    else { res = (n + 1).ToString("D2") + ".03." + g; }
                    break;

                case 4:
                    if (n == 30) { res = "01.05." + g; }
                    else { res = (n + 1).ToString("D2") + ".04." + g; }
                    break;

                case 5:
                    if (n == 31) { res = "01.06." + g; }
                    else { res = (n + 1).ToString("D2") + ".05." + g; }
                    break;

                case 6:
                    if (n == 30) { res = "01.07." + g; }
                    else { res = (n + 1).ToString("D2") + ".06." + g; }
                    break;

                case 7:
                    if (n == 31) { res = "01.08." + g; }
                    else { res = (n + 1).ToString("D2") + ".07." + g; }
                    break;

                case 8:
                    if (n == 31) { res = "01.09." + g; }
                    else { res = (n + 1).ToString("D2") + ".08." + g; }
                    break;

                case 9:
                    if (n == 30) { res = "01.10." + g; }
                    else { res = (n + 1).ToString("D2") + ".09." + g; }
                    break;

                case 10:
                    if (n == 31) { res = "01.11." + g; }
                    else { res = (n + 1).ToString("D2") + ".10." + g; }
                    break;

                case 11:
                    if (n == 30) { res = "01.12." + g; }
                    else { res = (n + 1).ToString("D2") + ".11." + g; }
                    break;

                case 12:
                    if (n == 31) { res = "01.01." + (g + 1); }
                    else { res = (n + 1).ToString("D2") + ".12." + g; }
                    break;

                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
            }
            return res;
        }
    }
}
