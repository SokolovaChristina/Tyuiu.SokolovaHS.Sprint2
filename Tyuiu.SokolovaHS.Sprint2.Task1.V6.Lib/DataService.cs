using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SokolovaHS.Sprint2.Task1.V6.Lib
{
    public class DataService : ISprint2Task1V6
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c == a);
            res[1] = (a != b) & (c != d + 41);
            res[2] = (a < c) || (d < b);
            res[3] = (a > c) && (d > b);
            res[4] = !(c <= d);
            res[5] = (b >= d) ^ (a >= c);

            return res;
        }
    }
}
