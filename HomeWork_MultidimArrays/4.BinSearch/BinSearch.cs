//4.Write a program, that reads from the console an array of N integers and an integer K,
//  sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class BinSearch
{
    static void Main()
    {
        int[] number = { 1, 5, 8, 10, 14, 19, 21 };// It is easy to create an array. I focused on the second part of thr task.
        int k = int.Parse(Console.ReadLine());

        int index = Array.BinarySearch(number, k);

        if (index > -1)
        {
            Console.WriteLine(number[index]);
        }
        else if (index == -1)
        {
            Console.WriteLine("There is no element <=K in your Array");
        }
        else
        {
            Console.WriteLine(number[-index - 2]);
        }
    }
}
