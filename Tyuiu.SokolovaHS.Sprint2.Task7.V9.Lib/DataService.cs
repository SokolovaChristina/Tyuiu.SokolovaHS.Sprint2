using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaHS.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res1 = (y <= Math.Sin(x));  
            bool res2 = (y >= 0.5);
            bool isInShadedArea = res1 && res2;

            return isInShadedArea;

        }
    }
}
