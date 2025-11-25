using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.UsoltsevGP.Sprint4.Task1.V28.Lib
{
    public class DataService : ISprint4Task1V28
    {
        public int Calculate(int[] array)
        {
            int multiply = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 1)
                {
                    multiply *= array[i];
                }
            }
            return multiply;
        }
    }
}
