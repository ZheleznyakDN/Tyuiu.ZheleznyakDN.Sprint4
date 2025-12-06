using Tyuiu.ZheleznyakDN.Sprint4.Task7.V1.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "135792468";
            int result = ds.Calculate(3, 3, value);
            Assert.AreEqual(4, result);
        }
    }
}
