using System;

namespace Lunes_Assignment1
{
    class Program
    {

        //1.1 Create a new console application.
        //1.2 Print all numbers from 1 to 100 to the console, in ascending order.
        //1.3 Print all numbers from 1 to 100 to the console in descending order.
        //1.4 Calculate the sum of numbers from 1 to n
        //1.5 Program two alternative versions of sum

        static void Main(string[] args)
        {
            Assignment1_2();
            Assignment1_3();
            Assignment1_4();
            Assignment1_5();
        }

        public static void Assignment1_2()
        {
            Console.WriteLine("Assignment 1.2");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Assignment1_3()
        {
            Console.WriteLine("Assignment 1.3");
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void Assignment1_4()
        {
            Console.WriteLine("Assignment 1.4");
            int sum = 0;
            Console.Write("Enter n for calculation: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        public static void Assignment1_5()
        {
            Console.WriteLine("Assignment 1.5 (Alternative Version)");
            int sum = 0;
            Console.Write("Enter n for calculation: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
