using Tyuiu.MihajlichenkoSB.Sprint1.Task5.V5.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int result = ds.Calculate(x);
            Assert.AreEqual(5, result);

            double x2 = 10.999;
            int resul = ds.Calculate(x);
            Assert.AreEqual(9, result);


            double x3 = 7.04;
            int resu = ds.Calculate(x);
            Assert.AreEqual(0, result);
        }
    }
}