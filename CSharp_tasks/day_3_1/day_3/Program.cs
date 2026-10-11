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

            Console.WriteLine("===== Guessing Game =====");
            Console.WriteLine("Guess a number between 50 and 75:");

            Random random = new Random();
            int numberToGuess = random.Next(50, 75);
            int userGuess = 0;
            int attempts = 0;
            int points = 10;
            while (userGuess != numberToGuess)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < numberToGuess)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (userGuess > numberToGuess)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                attempts++;
            }


            if(attempts == 2)
            {
                points = 7;
            }
            else if (attempts == 3)
            {
                points = 5;
            }
            else
            {
                points = 0;
            }

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Points: " + points);








        }
    }
}
