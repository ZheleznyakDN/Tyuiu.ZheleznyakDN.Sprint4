using Tyuiu.ZheleznyakDN.Sprint4.Task7.V1.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint4.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "135792468";

            Console.Title = "Спринт #4 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Матрицы и строки                                                  *");
            Console.WriteLine("* Задание #4.7                                                            *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"135792468\". Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 3 на 3 и подсчитайте количество четных чисел.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Размер матрицы: {n} x {m}");
            Console.WriteLine($"Исходная строка: \"{value}\"");
            Console.WriteLine($"Длина строки: {value.Length} символов");

            Console.WriteLine("\nМатрица:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (index < value.Length)
                    {
                        Console.Write($"{value[index]} ");
                        index++;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"Количество четных чисел в матрице: {result}");

            Console.ReadKey();
        }
    }
}
