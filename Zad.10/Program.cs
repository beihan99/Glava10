
// Дадена е матрица с проходими и непроходими клетки. Напишете рекурсивна програма, която намира всички пътища между две клетки в матрицата.

using System;


namespace Zad._10
{
    class Program
    {
        static int numberOfPaths(int m, int n)
        {
            int[,] count = new int[m, n];

            for (int i = 0; i < m; i++)
                count[i, 0] = 1;

            for (int j = 0; j < n; j++)
                count[0, j] = 1;

            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    count[i, j] = count[i - 1, j] + count[i, j - 1];

            return count[m - 1, n - 1];
        }

        static void Main()
        {
            Console.WriteLine(" Пътищата са: {0}", numberOfPaths(3, 3));
        }
    }
}