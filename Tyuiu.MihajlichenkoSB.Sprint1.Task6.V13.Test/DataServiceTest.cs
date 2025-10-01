using Tyuiu.MihajlichenkoSB.Sprint1.Task6.V13.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckWordsAlphabet("abc"));

            Assert.IsFalse(ds.CheckWordsAlphabet("cba"));

            Assert.IsFalse(ds.CheckWordsAlphabet(""));

            Assert.IsTrue(ds.CheckWordsAlphabet("aBcD"));

        }
    }
}