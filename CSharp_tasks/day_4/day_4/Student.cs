using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine();
        }
    }
}
