using Tyuiu.UsoltsevGP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.UsoltsevGP.Sprint4.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int n = 3; // строки
            int m = 4; // столбцы
            string value = "264795863157";
            int res = ds.Calculate(n, m, value);
            int wait = 37;

            Assert.AreEqual(wait, res);
        }
    }
}