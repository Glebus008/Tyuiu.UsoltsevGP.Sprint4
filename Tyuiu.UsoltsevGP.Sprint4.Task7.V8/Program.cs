using Tyuiu.UsoltsevGP.Sprint4.Task7.V8.Lib;
namespace Tyuiu.UsoltsevGP.Sprint4.Task7.V8
{
    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #4 | Выполнил: Усольцев Г. П. | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнил: Усольцев Глеб Павлович | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр '264795863157'. Преобразуйте ее в     *");
        Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string str = "264795863157";
        int rows = 3;
        int columns = 4;

        Console.WriteLine("Исходная строка: " + str);
        Console.WriteLine("Размер матрицы: " + rows + "x" + columns);

        Console.WriteLine("Матрица:");
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(str[index] + "\t");
                    index++;
            }
        Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(rows, columns, str);
        Console.WriteLine("Сумма нечетных чисел матрицы = " + result);

        Console.ReadLine();
        }
    }
}