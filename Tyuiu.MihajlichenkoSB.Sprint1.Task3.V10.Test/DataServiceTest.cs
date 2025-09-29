using Tyuiu.MihajlichenkoSB.Sprint1.Task3.V10.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string result = ds.NumberToMoney(23.6);
            Assert.AreEqual("23.6 руб. - это 23 руб. 60 коп.", result);

            result = ds.NumberToMoney(123.4567);
            Assert.AreEqual("123.457 руб. - это 123 руб. 46 коп.", result);

            result = ds.NumberToMoney(0.999);
            Assert.AreEqual("0.999 руб. - это 0 руб. 100 коп.", result);
        }
    }
}