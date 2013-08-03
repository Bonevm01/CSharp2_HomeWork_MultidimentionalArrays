//3.    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
//      located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 

using System;

class LongestSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        string[,] table = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                table[i, j] = Console.ReadLine();
            }
        }
        int length;
        int startX = 0;
        int startY = 0;
        int maxLength = 1;
        string direction = null;

        //Check in rows
        for (int i = 0; i < n; i++)
        {
            string match = table[i, 0];
            length = 1;
            for (int col = 1; col < m; col++)
            {
                if (match == table[i, col])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = i;
                        startY = col - maxLength + 1;
                        direction = "row";
                    }
                }
                else
                {

                    length = 1;
                    match = table[i, col];
                }
            }
        }

        //Check in columns
        for (int column = 0; column < m; column++)
        {
            string match = table[0, column];
            length = 1;
            for (int row = 1; row < n; row++)
            {
                if (match == table[row, column])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = row - maxLength + 1;
                        startY = column;
                        direction = "column";
                    }
                }
                else
                {
                    length = 1;
                    match = table[row, column];
                }
            }
        }

        //Check in rigth diagonals
        for (int row = n - 2; row >= 0; row--)
        {
            string match = table[row, 0];
            int col = 0;
            length = 1;
            int currRow = row;
            int curColumn = col;
            do
            {
                currRow++;
                curColumn++;
                if (table[currRow, curColumn] == match)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = row;
                        startY = col;
                        direction = "Rdiagonal";
                    }

                }
                else
                {
                    length = 1;
                    match = table[currRow, curColumn];
                }

            } while (currRow < n - 1 && curColumn < m - 1);

        }
        for (int col = 1; col < m - 1; col++)
        {
            int row = 0;
            string match = table[0, col];
            length = 1;
            int currRow = row;
            int curColumn = col;
            do
            {
                currRow++;
                curColumn++;
                if (table[currRow, curColumn] == match)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = row;
                        startY = col;
                        direction = "Rdiagonal";
                    }

                }
                else
                {
                    length = 1;
                    match = table[currRow, curColumn];
                }

            } while (currRow < n - 1 && curColumn < m - 1);
        }
        //Check in left diagonals
        for (int row = n - 2; row >= 0; row--)
        {
            string match = table[row, m - 1];
            int col = m - 1;
            length = 1;
            int currRow = row;
            int curColumn = col;
            do
            {
                currRow++;
                curColumn--;
                if (table[currRow, curColumn] == match)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = row;
                        startY = col;
                        direction = "Ldiagonal";
                    }

                }
                else
                {
                    length = 1;
                    match = table[currRow, curColumn];
                }

            } while (currRow < n - 1 && curColumn > 0);

        }
        for (int col = m - 2; col > 0; col--)
        {
            int row = 0;
            string match = table[0, col];
            length = 1;
            int currRow = row;
            int curColumn = col;
            do
            {
                currRow++;
                curColumn--;
                if (table[currRow, curColumn] == match)
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startX = row;
                        startY = col;
                        direction = "Ldiagonal";
                    }

                }
                else
                {
                    length = 1;
                    match = table[currRow, curColumn];
                }

            } while (currRow < n - 1 && curColumn > 0);
        }

        //This is the whole table
        Console.WriteLine("This is the whole table");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("{0,5} ", table[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Max length is {0}.", maxLength);
        Console.Write("The seuence starts at row {0}", startX);
        Console.Write(" and column {0} and it contains: ", startY);
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write("{0} ", table[startX, startY]);
        }

        Console.WriteLine(direction);
    }
}
