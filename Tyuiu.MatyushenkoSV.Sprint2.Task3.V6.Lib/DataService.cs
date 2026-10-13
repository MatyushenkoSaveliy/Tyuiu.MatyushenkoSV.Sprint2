using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MatyushenkoSV.Sprint2.Task3.V6.Lib
{
    public class DataService : ISprint2Task3V6
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x + Math.Pow((x - 15.0) / (x - 10.0), x - 3.0);
            }
            else
            {
                if (x == 0)
                {
                    double num = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10.0;
                    double den = Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12.0;
                    y = num / den;
                }
                else
                {
                    if (x > -10 && x < 0)
                    {
                        y = Math.Pow(Math.Pow(x, 4) + (1.0 / Math.Pow(x, 2)), x);
                    }
                    else
                    {
                        y = x + 10.0 * x - (1.0 / x);
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
