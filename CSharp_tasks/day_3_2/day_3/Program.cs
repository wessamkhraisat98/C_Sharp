using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] students = { "Ahmad", "Sara", "Omar", "Lina", "Yazan" };
            int[] grades = { 85, 92, 68, 75, 90 };

            int choice;

            do
            {
                Console.WriteLine("\n===== Main Menu =====");
                Console.WriteLine("1. Guessing Game");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Search for Student");
                Console.WriteLine("4. Check Student Result");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                switch (choice)
                {
                    case 1:

                        int secretNumber = random.Next(50, 76);
                        int guess = 0;
                        int attempts = 0;
                        int points = 0;

                        Console.WriteLine("\n===== Guessing Game =====");

                        while (guess != secretNumber)
                        {
                            Console.Write("\nGuess a number between 50 and 75: ");

                            if (!int.TryParse(Console.ReadLine(), out guess))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                continue;
                            }

                            if (guess < 50 || guess > 75)
                            {
                                Console.WriteLine("Number must be between 50 and 75.");
                                continue;
                            }

                            attempts++;

                            if (guess < secretNumber)
                            {
                                Console.WriteLine("Try a higher number.");
                            }
                            else if (guess > secretNumber)
                            {
                                Console.WriteLine("Try a lower number.");
                            }
                            else
                            {
                                Console.WriteLine("Congratulations!");

                                if (attempts == 1)
                                    points = 10;
                                else if (attempts == 2)
                                    points = 7;
                                else if (attempts == 3)
                                    points = 5;
                                else
                                    points = 0;
                            }
                        }

                        Console.WriteLine("\nAttempts: " + attempts);
                        Console.WriteLine("Points: " + points);

                        break;

                    case 2:

                        Console.WriteLine("\n===== Students =====");

                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + students[i]);
                        }

                        Console.WriteLine("\n===== Grades =====");

                        foreach (int grade in grades)
                        {
                            Console.WriteLine(grade);
                        }

                        break;

                    case 3:

                        Console.Write("\nEnter student name: ");
                        string name = Console.ReadLine();

                        int index = 0;
                        bool found = false;

                        while (index < students.Length)
                        {
                            if (students[index] ==  name)
                            {
                                Console.WriteLine("Student Found!");
                                Console.WriteLine("Name: " + students[index]);
                                Console.WriteLine("Grade: " + grades[index]);

                                found = true;
                                break;
                            }

                            index++;
                        }

                        if (!found)
                        {
                            Console.WriteLine("Student Not Found.");
                        }

                        break;

                    case 4:

                        Console.Write("\nEnter student's grade: ");

                        int gradeInput;

                        if (!int.TryParse(Console.ReadLine(), out gradeInput))
                        {
                            Console.WriteLine("Invalid grade!");
                            break;
                        }

                        if (gradeInput < 0 || gradeInput > 100)
                        {
                            Console.WriteLine("Invalid Grade!");
                        }
                        else if (gradeInput >= 90)
                        {
                            Console.WriteLine("Excellent");
                        }
                        else if (gradeInput >= 80)
                        {
                            Console.WriteLine("Very Good");
                        }
                        else if (gradeInput >= 70)
                        {
                            Console.WriteLine("Good");
                        }
                        else if (gradeInput >= 60)
                        {
                            Console.WriteLine("Pass");
                        }
                        else
                        {
                            Console.WriteLine("Fail");
                        }

                        break;

                    case 5:
                        Console.WriteLine("\nGoodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 5);

        }
    }
}
