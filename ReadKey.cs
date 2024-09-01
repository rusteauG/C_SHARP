using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Im learning c#");
            int asciiValue = Console.Read();
            Console.WriteLine(asciiValue); // This prints the ASCII value.
            char character = (char)asciiValue;
            Console.WriteLine(character); // This prints the actual character.

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char charEntered = keyInfo.KeyChar;
            Console.WriteLine($"You Pressed {charEntered}");

            // Console.ReadKey() method with the intercept parameter to suppress the key press from being displayed in the console:
            Console.WriteLine("Press any key (the key won't be displayed on the console):");
            // Read a key press without displaying it in the console
            ConsoleKeyInfo ConsoleKeyInfo = Console.ReadKey(intercept:true);
            // Display information about the key that was pressed
            Console.WriteLine("\nYou pressed: " + ConsoleKeyInfo.KeyChar);
            DateTime dat = DateTime.Now;
            Console.WriteLine("The time: {0:d} at {0:t}", dat);


            Console.WriteLine("Hello my name is neville");
            // Wait for 3 seconds (3000 milliseconds)
            Thread.Sleep(3000);

            Console.Clear();
            Console.WriteLine("Welcome to C#");
            Console.ReadKey();
            
        }
    }
}
