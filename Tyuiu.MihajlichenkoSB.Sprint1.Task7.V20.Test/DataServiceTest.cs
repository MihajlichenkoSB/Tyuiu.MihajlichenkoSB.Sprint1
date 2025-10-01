using Tyuiu.MihajlichenkoSB.Sprint1.Task7.V20.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(1, 1);
            // проверим, что округление работает
            Assert.AreEqual(Math.Round(result, 3), result);
        }

        [TestMethod]
        public void TestCalculateOther()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(2, 3);
            Assert.AreEqual(Math.Round(result, 3), result);
        }
    }
}
