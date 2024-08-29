using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecimalType();
            CharDataType();
            ObjectDataTypes();

        PrintObject(42);            // int
        PrintObject("Hello World"); // string
        PrintObject(9.81);          // double
        }

        static void DecimalType()
        {
            decimal totalAmount;
            totalAmount = 45.665M;
            decimal totalDollars, totalCents;

            totalDollars = decimal.Truncate(totalAmount);
            totalCents = totalAmount - totalDollars;
            Console.WriteLine($"{totalDollars,10:C}");
            Console.WriteLine($"{totalCents,10:C}");
            totalAmount = 45.67895342M;
            Console.WriteLine("Rounded to 0 dp is {0}", decimal.Round(totalAmount));
            Console.WriteLine("Rounded to 4 dp is {0}", decimal.Round(totalAmount, 4));

            totalAmount = -45.67M;
            decimal totalDollars1 = Decimal.Floor(totalAmount);
            decimal totalDollars2 = Decimal.Ceiling(totalAmount);
            Console.WriteLine("Rounding down: {0}", totalDollars1);
            Console.WriteLine("Rounding up Ceiling: {0}", totalDollars2);

        }




        static void CharDataType()
        {

            Console.WriteLine("Code Point 82 is {0}",char.ConvertFromUtf32(82));
            Console.WriteLine("Codepoint of R is {0}",char.ConvertToUtf32("R",0));


            int codePoint = 0x1F600; // Unicode code point for 😀 (Grinning Face)
            string character = char.ConvertFromUtf32(codePoint);
            Console.WriteLine(character);

            int asciiCodePoint = 65; // Code point for 'A'
            string charA = char.ConvertFromUtf32(asciiCodePoint);
            Console.WriteLine(charA);

            //char
            char digit = '5';
            char letter = 'A';
            char letterOrDigit = '9';
            char number = 'Ⅷ'; // Roman numeral eight
            char punctuation = '!';
            char separator = ' ';
            char whiteSpace = '\n';

            if (char.IsDigit(digit))
                Console.WriteLine($"{digit} is a digit.");

            if (char.IsLetter(letter))
                Console.WriteLine($"{letter} is a letter.");

            if (char.IsLetterOrDigit(letterOrDigit))
                Console.WriteLine($"{letterOrDigit} is a letter or a digit.");

            if (char.IsNumber(number))
                Console.WriteLine($"{number} is a numeric character.");

            if (char.IsPunctuation(punctuation))
                Console.WriteLine($"{punctuation} is a punctuation mark.");

            if (char.IsSeparator(separator))
                Console.WriteLine("This is a separator character.");

            if (char.IsWhiteSpace(whiteSpace))
                Console.WriteLine("This is a whitespace character.");




        }

        static void ObjectDataTypes()
        {
            List<object> mixedList = new List<object>();
            mixedList.Add(1);
            mixedList.Add("Hello");
            mixedList.Add(2.14);
            mixedList.Add(true);

            foreach (object o in mixedList)
            {
                Console.WriteLine($"Type: {o.GetType()},valu: {o}");
            }

            int num = 123;
            object obj = num;//boxing
            int unboxedNum = (int)num; //unboxing
            Console.WriteLine($"Boxed int {obj} Type:{obj.GetType()} , Unboxed to Int {unboxedNum} , type: {unboxedNum.GetType()}");

            // Check if the reference is object
            bool isBoxed = obj is object && obj.GetType().IsValueType;
            Console.WriteLine($"Is obj likely boxed? {isBoxed}");


            object anything;
            anything = 7;
            Console.WriteLine($"{anything} is {anything.GetType()}");


        }

       static void PrintObject(object obj)
        {
            Console.WriteLine($"The object is: {obj}");
        }

        


    }


}

