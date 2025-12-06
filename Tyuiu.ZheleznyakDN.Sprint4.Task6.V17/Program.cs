using Tyuiu.ZheleznyakDN.Sprint4.Task6.V17.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint4.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] array = { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };

            Console.Title = "Спринт #4 | Выполнил: Железняк Д.Н. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #4.6                                                            *");
            Console.WriteLine("* Вариант #46                                                             *");
            Console.WriteLine("* Выполнил: Железняк Дамир Николаевич | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Python\", \"JavaScript\", \"Java\", \"C#\",  *");
            Console.WriteLine("* \"Swift\", \"Kotlin\", \"Ruby\"]. Используя класс Array подсчитайте        *");
            Console.WriteLine("* количество элементов, длина которых равна 6.                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив строк:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i}] = \"{array[i]}\" (длина: {array[i].Length})");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine($"Количество элементов с длиной 6: {result}");

            Console.ReadKey();
        }
    }
}
