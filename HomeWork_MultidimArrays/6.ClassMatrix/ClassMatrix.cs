//6.* Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices,
//    indexer for accessing the matrix content and ToString().


using System;

class ClassMatrix
{
    static void Main()
    {
        Matrix table1 = new Matrix(2,3);
        Matrix table2 = new Matrix(2, 3);
        Random rgrt = new Random();
        for (int i = 0; i < table1.rows; i++)
        {
            for (int k = 0; k < table1.columns; k++)
            {
                table1[i, k] = rgrt.Next(0,20);
                table2[i, k] = rgrt.Next(0,20);
            }
        }
        Matrix newMatrix = table1 + table2;
        Matrix table4 = table1 - table2;

        Console.WriteLine("The first table is:");
        Console.WriteLine(table1);
        Console.WriteLine("The second table is:");
        Console.WriteLine(table2);
        Console.WriteLine("Table 1 + Table 2 = ");
        Console.WriteLine(newMatrix);
        Console.WriteLine("Table 1 - Table 2 = ");
        Console.WriteLine(table4);
    }
}

class Matrix
{
    public int rows, columns;
    private int[,] matrix;

    public Matrix(int a, int b)
    {
        if (a < 1 || b < 1)
        {
            throw new FormatException("Invalid parameters for creating a matrix!");
        }
        else
        {
            this.rows = a;
            this.columns = b;
            matrix = new int[a, b];
        }
    }

    public int this[int a, int b]
    {
        get
        {
            return this.matrix[a, b];
        }
        set
        {
            this.matrix[a, b] = value;
        }
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix newM;
        if (a.rows != b.rows || a.columns != b.columns)
        {
            throw new FormatException("Matrixes must have same dimensions!");
        }
        else
        {
            newM = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int k = 0; k < a.columns; k++)
                {
                    newM[i, k] = a[i, k] + b[i, k];
                }
            }
        }
        return newM;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix newM;
        if (a.rows != b.rows || a.columns != b.columns)
        {
            throw new FormatException("Matrixes must have same dimensions!");
        }
        else
        {
            newM = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int k = 0; k < a.columns; k++)
                {
                    newM[i, k] = a[i, k] - b[i, k];
                }
            }
            return newM;
        }
    }

    public override string ToString()
    {
        string result = "";
        int elementsMaxLenght = 0;
        foreach (var item in this.matrix)
        {
            if (Convert.ToString(item).Length>elementsMaxLenght)
            {
                elementsMaxLenght = Convert.ToString(item).Length;
            }
        }
        for (int row = 0; row < this.rows; row++)
        {
            for (int col = 0; col < this.columns; col++)
            {
                result += Convert.ToString(this.matrix[row, col]).PadLeft(elementsMaxLenght + 1, ' ');
            }
            result += "\n";
        }
        return result;
    }
}
