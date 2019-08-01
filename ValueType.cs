using System;

namespace BasicCSharp
{
    class Student
    {
        public string name;
        public int age;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int p, q;
            p = 5;
            q = p;
            q = 6;
            Console.WriteLine("p:{0},q:{1}",p,q);
        }
    }       
}
