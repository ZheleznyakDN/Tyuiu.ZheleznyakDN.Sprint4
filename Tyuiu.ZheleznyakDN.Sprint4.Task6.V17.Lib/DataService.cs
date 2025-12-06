using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZheleznyakDN.Sprint4.Task6.V17.Lib
{
    public class DataService : ISprint4Task6V17
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length == 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
