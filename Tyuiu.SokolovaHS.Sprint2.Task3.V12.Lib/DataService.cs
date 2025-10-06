using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SokolovaHS.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                // x + ((x+1)/(x-1))^x
                y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                // 1 + cos(√(x+1))
                y = Math.Round(1 + Math.Cos(Math.Sqrt(x + 1)), 3);
            }
            else if ((-16 < x) && (x < 2))
            {
                // (7 + 5/x²)^x
                y = Math.Pow(7 + (5 / (x * x)), x);
            }
            else if (x < -16)
            {
                // x + 10x - (1/x)
                y = x + (10 * x) - (1 / x);
            }

            return y;
        }
    }
}
