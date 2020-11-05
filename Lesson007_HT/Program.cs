using System;

namespace Lesson007_HT
{
    class MainClass
    {
        static void Calculate(int num1, int num2, int num3)
        {
            int res1 = num1 / 5;
            Console.WriteLine(res1);
            int res2 = num2 / 5;
            Console.WriteLine(res2);
            int res3 = num3 / 5;
            Console.WriteLine(res3);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Calculate(num1, num2, num3);
            
        }
    }
}
