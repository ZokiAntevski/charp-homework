using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework");

            Console.WriteLine("Eenter the first number");
            bool ifFirstSuccessful = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Enter the second number");
            bool ifSecondSuccessful = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Enter the operator");
            string operation = Console.ReadLine();
            
            if(ifFirstSuccessful && ifSecondSuccessful)
            {
                if (operation == "+")
                {
                    int result = firstNumber + secondNumber;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == "-")
                {
                    int result = firstNumber - secondNumber;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == "*")
                {
                    int result = firstNumber * secondNumber;
                    Console.WriteLine("The result is: " + result);
                }
                else if (operation == "/")
                {
                    int result = firstNumber / secondNumber;
                    Console.WriteLine("The result is: " + result);
                }
            }
            else
            {
                Console.WriteLine("Wrong input, plese try again!");
            }
            

          
          
            Console.ReadLine();    
        }
    }
}
