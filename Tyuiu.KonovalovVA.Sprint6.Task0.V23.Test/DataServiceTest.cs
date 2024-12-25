using Tyuiu.KonovalovVA.Sprint6.Task0.V23.Lib;
namespace Tyuiu.KonovalovVA.Sprint6.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            DataSerivce ds = new DataSerivce();
            double wait = 3;
            double ans = ds.Calculate(x);
            Assert.AreEqual(wait, ans);

        }
    }
}