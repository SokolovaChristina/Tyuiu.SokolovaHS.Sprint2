using Tyuiu.SokolovaHS.Sprint2.Task7.V9.Lib;
namespace Tyuiu.SokolovaHS.Sprint2.Task7.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            bool result1 = ds.CheckDotInShadedArea(1.57, 0.8);
            Assert.AreEqual(true, result1);  

            bool result2 = ds.CheckDotInShadedArea(0, 0);
            Assert.AreEqual(false, result2); 

            bool result3 = ds.CheckDotInShadedArea(0.52, 0.5);
            Assert.AreEqual(true, result3);

            bool result4 = ds.CheckDotInShadedArea(3.14, 0.1); 
            Assert.AreEqual(false, result4);

            bool result5 = ds.CheckDotInShadedArea(1.0, 0.6); 
            Assert.AreEqual(true, result5);
        }
    }
}
