using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram = true;

            while (continueProgram)
            {
                int value;
                bool isValid = false;
                while (!isValid)
                {

                    Console.Write("Please Enter a Number > ");
                    isValid = int.TryParse(Console.ReadLine(), out value);

                    if (!isValid)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();  // Wait for the user to press a key
                        Console.Clear();     // Then clear the screen
                    }

                    int start = 0;
                    while (start < value)
                    {
                        Console.WriteLine(start);
                        start += 2;

                    }
                    string targetChoice = string.Empty;
                    do
                    {
                        Console.WriteLine("Do you want to Continue...Type  Yes or No");
                        targetChoice = Console.ReadLine();

                        if (targetChoice.ToLower() != "no" && targetChoice.ToLower() != "yes")
                        {
                            Console.WriteLine("Invalid Input Please Type  Yes or No");
                        }

                    } while (targetChoice.ToLower() != "no" && targetChoice.ToLower() != "yes");


                    // Continue or exit based on user input
                    if (targetChoice.ToLower() == "no")
                    {
                        continueProgram = false;
                    }
                    else
                    {
                        Console.Clear();  // Clear the screen for the next iteration
                    }

                }
            }
        }
    }
}
