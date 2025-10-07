using Tyuiu.SokolovaHS.Sprint2.Task4.V5.Lib;
namespace Tyuiu.SokolovaHS.Sprint2.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidConditution1()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 59.537;
            Assert.Equals(wait, res);


        }
        [TestMethod]
        public void ValidConditution2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 25;
            Assert.Equals(wait, res);
        }
    }
}
