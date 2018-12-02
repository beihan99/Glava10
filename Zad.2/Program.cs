
// Напишете рекурсивна програма, която генерира и отпечатва всички комбинации с повторение на k елемента над n-елементно множество.

using System;


namespace Zad._2
{
    class Program
    {
        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write(" {0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
        }

        static void Main()
        {
            Console.Write(" Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write(" Въведете K: ");
            int k = Int32.Parse(Console.ReadLine());
            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n);
        }
    }
}