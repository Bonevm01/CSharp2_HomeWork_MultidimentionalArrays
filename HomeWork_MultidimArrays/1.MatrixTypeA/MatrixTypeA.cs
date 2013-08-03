//Exercise 1a

using System;

class MatrixTypeA
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        for (int column = 0; column < n; column++)
        {
            for (int row = 0; row < n; row++)
            {
                table[row, column] = column * n + row + 1;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,2} ", table[i, j]);
            }
            Console.WriteLine();
        }
    }
}
