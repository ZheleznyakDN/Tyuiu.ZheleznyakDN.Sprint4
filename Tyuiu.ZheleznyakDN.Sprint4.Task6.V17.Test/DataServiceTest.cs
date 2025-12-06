using Tyuiu.ZheleznyakDN.Sprint4.Task6.V17.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint4.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
            int result = ds.Calculate(array);
            Assert.AreEqual(2, result);
        }
    }
}
