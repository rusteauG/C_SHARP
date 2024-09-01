//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramindPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pattern1(10);
            //pattern2(5);
            //pattern3(5);
            //pattern4(5);
            //pattern5(15);

            pattern7(5);
        }


        static void pattern1(int n)
        {
            /*
    (1.) 
    *****
    *****
    *****
    *****
    ***** 

    */
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    Console.Write($" * ");

                }
                Console.WriteLine();
            }

        }
        static void pattern2(int n)
        {
            //(2).
            /*
                *
                **
                ***
                ****
                *****
            */
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($" * ");
                }
                Console.WriteLine();
            }
        }


        static void pattern3(int n)
        {
            /*
             3.  
            *****
            ****
            ***
            **
            *
             */

            for (int row = 1; row <= n; row++)
            {
                for (int spaces = 1; spaces <= n - row; spaces++)
                {
                    Console.Write("   ");
                }
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(" * ");
                }


                Console.WriteLine();
            }

        }

        static void pattern4(int n)
        {
            /*
        1
        1 2
        1 2 3
        1 2 3 4
        1 2 3 4 5
             */

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col}");
                }
                Console.WriteLine();
            }


        }

        static void pattern5(int n)
        {
            /*
             *
             * *
             * * *
             * * * *
             * * *
             * *
             * 
             
             */

            for (int row = 1; row <= 2 * n - 1; row++)
            {
                int totalCols = default;
                if (row > n)
                {
                    totalCols = 2 * n - row;
                }
                else
                {
                    totalCols = row;
                }
                for (int col = 1; col <= totalCols; col++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }




        static void pattern6(int n)
        {
            for(int row = 1;row <=  n; row++)
            {
                for( int col = 1; col <= n -row+1; col++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }


        static void pattern7(int n)
            /*
           * * * * *
             * * * *
               * * *
                 * *
                   * 
             */


        {
            int spaces = default;
            for(int row=1;row <= n; row++)
            {
                for(spaces = 1; spaces <=row-1;spaces++)
                {
                    Console.Write("   ");
                }
                for(int col = 0;col <= n-spaces; col++)
                {
                    Console.Write(" * ");
                }

            Console.WriteLine();
            }
        }
    }
}