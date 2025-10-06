using Tyuiu.SokolovaHS.Sprint2.Task2.V9.Lib;
namespace Tyuiu.SokolovaHS.Sprint2.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 10;
            int y = 3;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);

        }
    }
}
