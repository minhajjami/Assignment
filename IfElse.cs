using System;

namespace BasicCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10, j = 20;

            if (i > j)
                Console.WriteLine("i is greater than j");
            else if (i < j)
                Console.WriteLine("i is less than j");
            else if (i == j)
                Console.WriteLine("i is equal to j");
        }
    }       
}
