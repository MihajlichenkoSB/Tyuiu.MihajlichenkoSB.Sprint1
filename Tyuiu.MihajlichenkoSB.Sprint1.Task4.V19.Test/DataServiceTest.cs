using Tyuiu.MihajlichenkoSB.Sprint1.Task4.V19.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(5, 3);
            Assert.AreEqual(2.667, result);

            var res = ds.Calculate(-1, -3);
            Assert.AreEqual(-1.333, result);

            ds.Calculate(2, 5);
        }
    }
}