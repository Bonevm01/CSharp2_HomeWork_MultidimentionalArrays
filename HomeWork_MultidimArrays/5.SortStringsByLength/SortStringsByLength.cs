//5.You are given an array of strings. Write a method that sorts the array by the length of its elements
//  (the number of characters composing them).


using System;

class SortStringsByLength
{
    static void Main()
    {
        string[] myArray = {"6666","55555","888","444444","3333333","9","77" };
        Array.Sort(myArray, (x, y) => x.Length.CompareTo(y.Length));
        //Print
        Console.WriteLine("Sorted strings by their length:");
        PrintArray(myArray);
        Console.WriteLine();

        //Another deicision - just to practice Array.Sort()
        string[] myNewArray = { "cccc", "ddddd", "fff", "aaaaaaa", "bb", "q", "iiiiiiiiii" };
        int[] lengths = new int[myNewArray.Length];
        for (int i = 0; i < lengths.Length; i++)
        {
            lengths[i] = myNewArray[i].Length;

        }
        Array.Sort(lengths, myNewArray);
        Console.WriteLine("Sorted strings by their length(Type2):");
        PrintArray(myNewArray);
    }

    private static void PrintArray(string[] myNewArray)
    {
        for (int i = 0; i < myNewArray.Length; i++)
        {
            Console.Write("{0} ", myNewArray[i]);
        }
        Console.WriteLine();
    }
}
