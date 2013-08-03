using System;

class MatrixTypeB
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        int mincolumn = 0;
        int count = 1;
        while (count<=n*n)
        {
            for (int row = 0; row < n; row++)
            {
                table[row, mincolumn] = count;
                count++;
            }
            mincolumn++;
            if (mincolumn == n)
            {
                break;
            }

            for (int row = n - 1; row >= 0; row--)
            {
                table[row, mincolumn] = count;
                count++;
            }
            mincolumn++;
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
