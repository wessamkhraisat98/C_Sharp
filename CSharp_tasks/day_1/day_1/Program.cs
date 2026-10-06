using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Wessam";
            int Age = 25;
            int Grade = 100;
            float Average = 99.9f;
            char Gender = 'M';
            bool Active = true;

            Console.WriteLine("===== Student Information =====");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
            Console.WriteLine($"Average: {Average}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Active: {Active}");



            Console.WriteLine("===== Students =====");
            string[] Names = { "Wessam", "Ali", "Ahmed", "Mohamed" };
            Console.WriteLine($"Student 1: {Names[0]}");
            Console.WriteLine($"Student 2: {Names[1]}");
            Console.WriteLine($"Student 3: {Names[2]}");
            Console.WriteLine($"Student 4: {Names[3]}");


            Console.WriteLine("===== Before Change  =====");

            Console.WriteLine($"Student 1: {Names[0]}");
            Console.WriteLine($"Student 2: {Names[1]}");
            Console.WriteLine($"Student 3: {Names[2]}");
            Console.WriteLine($"Student 4: {Names[3]}");
            Console.WriteLine($"Student Length: {Names.Length}");

            Names[3] = "Hossam";
            Console.WriteLine("===== After  Change  =====");

            Console.WriteLine($"Student 1: {Names[0]}");
            Console.WriteLine($"Student 2: {Names[1]}");
            Console.WriteLine($"Student 3: {Names[2]}");
            Console.WriteLine($"Student 4: {Names[3]}");
        }
    }
}
