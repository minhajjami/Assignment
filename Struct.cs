using System;

namespace BasicCSharp
{
    struct Student
    {
        public int StudentId;
        public string FirstName;
        public string LastName;
        public int Age;

        public Student(int sid,string fname,string lname,int age)
        {
            StudentId = sid;
            FirstName = fname;
            LastName = lname;
            Age = age;
        }

        public string getFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Student1 = new Student(1, "Minhaj", "Jami", 23);
            var Student2 = new Student(1, "Hasanur", "Rahman", 38);

            Console.WriteLine(Student1.getFullName());
            Console.WriteLine(Student2.getFullName());
        }
    }

        
}
