using System;
class Program
{
    public static void Main()
    {
        int[] EvenNumbers = new int[3];
        EvenNumbers[0] = 0;
        EvenNumbers[1] = 2;
        EvenNumbers[2] = 4;

        int[] OddNumbers = { 1, 3, 5 };

        Console.WriteLine("Printing EVEN Numbers");

       
        for (int i = 0; i < EvenNumbers.Length; i++)
        {
            Console.WriteLine(EvenNumbers[i]);
        }

        Console.WriteLine("Printing ODD Numbers");

        for (int i = 0; i < OddNumbers.Length; i++)
        {
            Console.WriteLine(OddNumbers[i]);
        }
    }
}

