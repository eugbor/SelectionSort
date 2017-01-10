using System;
/// <summary>
/// Выполнить сортировку выбором целочисленного массива.
/// </summary>
namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2, 5, 1, 3, 4};
            for (int i = 0; i < a.Length; i++)
            {
                int min = i;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[min] > a[j])
                    {
                        min = j;
                    }
                }
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
