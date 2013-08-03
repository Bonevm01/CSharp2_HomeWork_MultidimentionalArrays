//2.Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;

class MaxSum3x3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] table = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                table[i, j] = int.Parse(Console.ReadLine());
            }
        }
        int maxSum = int.MinValue;
        int maxX = 0;
        int maxY = 0;
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int sum = int.MinValue;
                for (int srow = row; srow < row + 3; srow++)
                {
                    for (int scol = col; scol < col + 3; scol++)
                    {
                        sum += table[srow, scol];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxX = row;
                    maxY = col;
                }

            }
        }
        //This is the whole table
        Console.WriteLine("This is the whole table");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,2} ", table[i, j]);
            }
            Console.WriteLine();
        }
        //These are the elements 3x3 with max sum:
        Console.WriteLine("These are the elements 3x3 with max sum:");
        for (int i = maxX; i < maxX + 3; i++)
        {
            for (int j = maxY; j < maxY + 3; j++)
            {
                Console.Write("{0,2} ", table[i, j]);
            }
            Console.WriteLine();
        }
    }
}
