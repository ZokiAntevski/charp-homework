using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 02");

            Console.WriteLine("Eenter the first number");
            bool ifFirstSuccessful = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number");
            bool ifSecondSuccessful = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter the third number");
            bool ifThirdSuccessful = int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.WriteLine("Enter the four number");
            bool ifFourSuccessful = int.TryParse(Console.ReadLine(), out int fourNumber);

            int result = (firstNumber + secondNumber + thirdNumber + fourNumber) / 4;

            if(ifFirstSuccessful && ifSecondSuccessful && ifThirdSuccessful && ifFourSuccessful)
            {
                Console.WriteLine("The average of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourNumber + " is: " + result);
            }
            else
            {
                Console.WriteLine("Invalid number, please try again!");
            }
            

            Console.ReadLine();
        }
    }
}
