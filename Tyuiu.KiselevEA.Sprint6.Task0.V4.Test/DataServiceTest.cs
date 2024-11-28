using Tyuiu.KiselevEA.Sprint6.Task0.V4.Lib;
namespace Tyuiu.KiselevEA.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate();
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}