using System;

namespace BasicCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 2)
            {
                Console.WriteLine("Value of i: {0}", i);
                int j = 1;

                i++;

                while (j < 2)
                {
                    Console.WriteLine("Value of j: {0}", j);
                    j++;
                }
            }
        }    
    }       
}
