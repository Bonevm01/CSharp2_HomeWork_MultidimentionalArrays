using System;

class MatrixTypeD
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        int minCol = 0;
        int maxCol = n - 1;
        int minRow = 0;
        int maxRow = n - 1;
        int count = 1;
        while (count<=n*n)
        {
            for (int row = minRow; row <= maxRow; row++)
            {
                table[row, minCol] = count;
                count++;
            }
            minCol++;
            for (int col = minCol; col <= maxCol; col++)
            {
                table[maxRow, col] = count;
                count++;
            }
            maxRow--;
            for (int row = maxRow; row >= minRow; row--)
            {
                table[row, maxCol] = count;
                count++;
            }
            maxCol--;
            for (int col = maxCol; col >= minCol; col--)
            {
                table[minRow, col] = count;
                count++;
            }
            minRow++;
        }
        //Print
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
