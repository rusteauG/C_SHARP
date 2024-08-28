//ArrayList
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace QuestPond_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Hello");
            Console.WriteLine(class1.GetTimeDate());
           //want to move an int to a double
           int i = 10000;
            double d = i;
            Console.WriteLine(d + " : " + d.GetType()); //implicit casting from 

            int intValue = 123;
            long longValue = intValue;

            char charValue = 'A';
            int intChar = charValue;
            Console.WriteLine(intChar);


            float floatValue = 12.45f;
            double doubleValue =floatValue;
            Console.WriteLine(doubleValue);


            string str = "string";
            object obj = str;
            Console.WriteLine(str);


            //Call ArrayList
            if (class1.ArrayListTest())
            {
                Console.WriteLine("ISVALID");
            }
            else { Console.WriteLine("NOT VALID"); }

            class1.Lookup();

            Console.ReadKey();
        }
    }
}





//CLASS
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Common.Class1;

namespace Common
{
    public class Class1
    {
        public string GetTimeDate()
        {
            return DateTime.Now.ToString();
        }

        public bool ArrayListTest()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(false);

            foreach (object item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerable listCollection = list;
            foreach (object item in listCollection)
            {
                Console.WriteLine(item);
            }
            //unboxing
            bool isValid = (bool)list[2];
            return isValid;
        }


        public void Lookup()
        {
            Dictionary<string, string> lookup = new Dictionary<string, string>();
            string key = "fish";
            lookup["animal"] = "Not a Human";
            lookup[key] = "Not a Humand that swims";
            lookup["human"] = "Us";


            Console.WriteLine($"The Def of {key} is {lookup[key]} ");

            Dictionary<DaysOfWeek, string> dayDescriptions = new Dictionary<DaysOfWeek, string>();
            // Add values to the dictionary
            dayDescriptions[DaysOfWeek.Sunday] = "Rest and recharge.";
            dayDescriptions[DaysOfWeek.Monday] = "Back to work.";
            dayDescriptions[DaysOfWeek.Tuesday] = "Keep the momentum going.";
            dayDescriptions[DaysOfWeek.Wednesday] = "Halfway through!";
            dayDescriptions[DaysOfWeek.Thursday] = "Almost there.";
            dayDescriptions[DaysOfWeek.Friday] = "Weekend is coming.";
            dayDescriptions[DaysOfWeek.Saturday] = "Time to relax.";

            foreach (DaysOfWeek dayOfWeek in dayDescriptions.Keys)
            {
                Console.WriteLine($"On {dayOfWeek} you should : {dayDescriptions[dayOfWeek]}");
            }


            Console.WriteLine("Dictionary Examples");
            Dictionary<int, string> students = new Dictionary<int, string>();
            //Adding items
            students.Add(1, "Neville");
            students.Add(2, "Lola");
            students.Add(3, "Mora");

            //Accessing the values
            string studentName = students[1];
            Console.WriteLine(studentName);

            //Checking for a Key:
            if (students.ContainsKey(2))
            {
                Console.WriteLine("Student ID 2 is in the dictionary.");

            }
            //upadating a value
            students[2] = "Bboby";
            for (int i = 1; i <= students.Count; i++) { Console.WriteLine(students[i]); }

            Console.WriteLine();
            Console.WriteLine("For Loop After Remove");
            //remove an item
            students.Remove(2);
       foreach (int i in students.Keys) { Console.WriteLine(students[i]); } Console.WriteLine();
            //or
            foreach (var student in students) { Console.WriteLine(student); }
        }

         

        // create an enum for the days of the week and then use this enum as the key in a Dictionary
        public enum DaysOfWeek
        {

            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }



    }




}

