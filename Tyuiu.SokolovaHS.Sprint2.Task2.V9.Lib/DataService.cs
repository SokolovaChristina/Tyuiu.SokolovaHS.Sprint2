using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaHS.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 13) && (y >= 3) && (y <= 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}


//((x >= 3) && (x <= 13) && (y >= 3) && (y <= 4) && (y >= 9) && (y <= 11) && ()