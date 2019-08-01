using System;

namespace BasicCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 5)
                    break;

            } while (true);

        }
    }

        
}
