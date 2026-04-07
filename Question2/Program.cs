using System;

class Program
{
    static void Main()
    {
        int[] arr = { 12, 45, 7, 89, 23 };

        int largest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
        }

        Console.WriteLine("Largest number is: " + largest);
    }
}
