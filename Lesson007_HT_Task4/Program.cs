using System;

namespace Lesson007_HT_Task4
{
    class MainClass
    {
        static double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            double result = factorial_Recursion(number);
            Console.WriteLine($"Sproby: {result}");
        }
    }
}
