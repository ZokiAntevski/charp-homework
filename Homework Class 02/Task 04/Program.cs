using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 04");

            Console.WriteLine("Please enter a number");
            bool userInputSuccessful = int.TryParse(Console.ReadLine(), out int userNumber);
            if (userInputSuccessful)
            {
                if(userNumber % 3 == 0 && userNumber % 5 == 0)
                {
                    Console.WriteLine("Tik-Tak");
                }
                else if(userNumber % 3 == 0)
                {
                    Console.WriteLine("Tik");
                }
                else if(userNumber % 5 == 0)
                {
                    Console.WriteLine("Tak");
                }
            }
            else
            {
                Console.WriteLine("Bad number!!!");
            }
            Console.ReadLine();
        }
    }
}
