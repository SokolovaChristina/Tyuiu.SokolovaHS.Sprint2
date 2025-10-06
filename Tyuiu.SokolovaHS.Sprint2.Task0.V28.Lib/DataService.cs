using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaHS.Sprint2.Task0.V28.Lib

{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x + 624 != y;
            res[2] = y < x;
            res[3] = x > y;
            res[4] = y <= x;
            res[5] = x >= y;

            return res;
        }
    }
}
