using Tyuiu.SokolovaHS.Sprint2.Task1.V6.Lib;
namespace Tyuiu.SokolovaHS.Sprint2.Task1.V6.Test
{
    [TestClass]
    public sealed class DataSrviceTest
    {
        [TestMethod]
        public void GetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 915;
            int b = 169;
            int c = 174;
            int d = 133;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
