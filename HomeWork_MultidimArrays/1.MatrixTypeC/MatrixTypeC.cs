using System;

class MatrixTypeC
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] table = new int[n, n];
        int startcolumn = 0;
        int startRow = n - 1;
        int currentRow = startRow;
        int currentCol = startcolumn;
        int count = 1;
        table[currentRow, currentCol] = count;
        count++;
        while (true)
        {
            //Up
            startRow--;
            if (startRow < 0)
            {
                startRow = 0;
                startcolumn++;
            }
            currentRow = startRow;
            currentCol = startcolumn;
            table[currentRow, currentCol] = count;
            if (currentRow == 0 && currentCol == n - 1)
            {
                break;
            }
            count++;
            //Down-Left
            do
            {
                /*currentRow++;
                currentCol++;*/
                table[++currentRow, ++currentCol] = count;
                count++;
            } while (currentRow < n - 1 && currentCol < n - 1);

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
