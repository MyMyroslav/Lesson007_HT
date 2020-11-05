using System;

namespace Lesson007_HT_Task3
{
    class MainClass
    {
       
        static void bank (int num)
        {
            int i = 0;
            int debt = 700;
            while (i < 7)
            { 
                if(num < 700 && num >= 100 && debt != 0)
                {
                    Console.WriteLine("Enter count of money: ");
                    int sum = int.Parse(Console.ReadLine());
                    
                    int payment = debt - sum;
                    debt = payment;
                    Console.WriteLine($"Remains to close - {payment}");
                    continue;
                    
                }
                else
                {
                    Console.WriteLine("Debt is closed");
                        break;
                }
                
            }
            
        }
        public static void Main(string[] args)
        {
            bank(100);
        }
    }
}
