using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;
            while (continueProgram)
            {
                // Prompt the user to enter a string
                Console.Write("Please enter a string: ");
                string input = Console.ReadLine();

                string reversedString = ReverseString(input);
                Console.WriteLine($"Reversed string: {reversedString}");

                // Ask the user if they want to continue
                string targetChoice = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to reverse another string? Type Yes or No:");
                    targetChoice = Console.ReadLine();
                    if (targetChoice.ToLower() != "no" && targetChoice.ToLower() != "yes")
                    {
                        Console.WriteLine("Invalid input. Please type Yes or No.");
                    }
                } while (targetChoice.ToLower() != "no" && targetChoice.ToLower() != "yes");

                // Continue or exit based on user input
                if (targetChoice.ToLower() == "no")
                {
                    continueProgram = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
        static string ReverseString(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
