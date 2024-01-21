using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


//Ethan Hoopes
//The purpose of this program is to simulate rolling to dice and calculating the percentages of rolls
namespace ConsoleApp2
{
    class betterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("");
            Console.WriteLine("How many dice rolls would you like to simulate?");
            string? userInput = Console.ReadLine(); //this line has CS8600

            if (userInput != null)
            {
                try
                {
                    int number = int.Parse(userInput);
                    Console.WriteLine("You entered the number: " + number);
                    calculateDice(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input was not a valid number.");
                }
            }
            else
            {
                Console.WriteLine("No input received.");
            }
        }

        static void calculateDice(int number)
        {
            int[] results = new int[13];
            Random r = new Random();
            for (int iCount = 0; iCount < number; iCount++)
            {
                int die1 = r.Next(1, 7);
                int die2 = r.Next(1, 7);
                int sum = die1 + die2;
                results[sum]++;
            }

            Console.WriteLine("Dice Roll Distribution:");
            for (int i = 2; i <= 12 ; i++)
            {
                double percentage = (double)results[i] / number * 100;
                string asterisks = new string('*', (int)(percentage / 2)); // Adjust the number of asterisks as per your histogram scale
                Console.WriteLine($"{i}: {asterisks} ({percentage:F2}%)");
            }
        }
    }
}
