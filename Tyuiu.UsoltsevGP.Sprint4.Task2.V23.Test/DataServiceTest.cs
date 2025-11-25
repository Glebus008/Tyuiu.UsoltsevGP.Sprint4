using Tyuiu.UsoltsevGP.Sprint4.Task2.V23.Lib;
namespace Tyuiu.UsoltsevGP.Sprint4.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Checked()
        {
            DataService ds = new DataService();
            int[] array = { 3, 4, 6, 8, 4, 8 };
            int res = ds.Calculate(array);
            int wait = 26;
        }
    }
}
