using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = System.Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is your grade?");
            string grade = Console.ReadLine();

            Console.WriteLine("What is your average?");
            double average = System.Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your gender?");
            char gender = System.Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"================================\r\n        STUDENT SUMMARY\r\n================================\r\n");

            Console.WriteLine("Welcome " + name + "!");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Gender: " + gender);


            Console.WriteLine("===== Name Information =====");
            Console.WriteLine("Original Name: " + name);
            Console.WriteLine("Uppercase Name: " + name.ToUpper());
            Console.WriteLine("Lowercase Name: " + name.ToLower());
            Console.WriteLine("First Character: " + name[0]);

            double newAverage = average + 5;
            Console.WriteLine("Original Average: " + average);
            Console.WriteLine("Bonus Marks: " + 5);
            Console.WriteLine("New Average: " + newAverage);


            Console.WriteLine("===== Student Status =====");

            Console.WriteLine("New Average: " + newAverage);
            if (newAverage >= 50) { 
                Console.WriteLine("Status: Passed"); 
            }
            else { 
                Console.WriteLine("Status: Failed"); 
            }


            if (age >= 18)
            {
                Console.WriteLine("Adult: True");
            }
            else
            {
                Console.WriteLine("Adult: False");
            }







        }
    }
}
