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
            var s1 = new Student();
            s1.name = "Minhaj";
            s1.age = 23;

            var s2 = s1;
            s2.name = "Salman";
            s2.age = 26;

            Console.WriteLine("Student1 Name:{0},Student1 Age:{1}",s1.name,s1.age);
            Console.WriteLine("Student2 Name:{0},Student2 Age:{1}",s2.name,s2.age);

        }
    }       
}
