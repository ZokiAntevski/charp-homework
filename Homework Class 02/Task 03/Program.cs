using System;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 03");

            Console.WriteLine("Eenter the first number");
            bool ifFirstSuccessful = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number");
            bool ifSecondSuccessful = int.TryParse(Console.ReadLine(), out int secondNumber);
            int temporary = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temporary;

            if(ifFirstSuccessful && ifSecondSuccessful)
            {
                Console.WriteLine("After swaping:");
                Console.WriteLine("First number: " + firstNumber);
                Console.WriteLine("Second number: " + secondNumber);

            }
            else
            {
                Console.WriteLine("You enter invalid number, please try again!");
            }


            Console.ReadLine();
        }
    }
}
