using Tyuiu.UsoltsevGP.Sprint4.Task5.V11.Lib;
namespace Tyuiu.UsoltsevGP.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Усольцев Г. П. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Усольцев Глеб Павлович | РППб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2.                           *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                   *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количство столбцов");
            int colums = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, colums];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    mtrx[i, j] = rnd.Next(-7, 2);
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (mtrx[i, j] > 0)
                    {
                        mtrx[i, j] = 1;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(mtrx);
            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(res[i, j] + " "); // Убрали ,4
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}