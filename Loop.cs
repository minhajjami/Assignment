using System;

namespace BasicCSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, count = 0, sum = 0;

            Console.WriteLine("Enter an Integer :");
            num = int.Parse(Console.ReadLine());

            for(count=1; count<=num;count++)
            {
                sum += count;
            }

            Console.WriteLine("Sum = {0}",sum);
        }
    }       
}
