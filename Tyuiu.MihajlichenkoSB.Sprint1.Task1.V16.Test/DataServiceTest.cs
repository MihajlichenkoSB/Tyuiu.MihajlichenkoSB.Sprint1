using Tyuiu.MihajlichenkoSB.Sprint1.Task1.V16.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataServiceTest ds = new DataServiceTest();
            Double x = 1.0;
            Double a = 2.0;
            Double y = 3.0;
            var res = ds.Calculate(x, a, y);
            Assert.AreEqual(-1, res);
        }

        private int Calculate(double x, double a, double y)
        {
            throw new NotImplementedException();
        }
    }
}