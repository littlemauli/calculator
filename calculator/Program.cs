using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");
            
            Console.WriteLine("Please enter your first number:");
            string myFirstString = Console.ReadLine();
            int a = int.Parse(myFirstString);
            
            Console.WriteLine("Please enter your second number:");
            string mySecondString = Console.ReadLine(); 
            int b = int.Parse(mySecondString);
            
            Console.WriteLine("Please enter your chosen operator:");
            String operatorChoice = Console.ReadLine();

            double answer;
            if (operatorChoice == "+")
            {
                answer = a+b;
            }
            else if (operatorChoice == "-")
            {
                answer = a - b;
            }
            else if (operatorChoice == "*")
            {
                answer = a * b;
            }
            else if (operatorChoice == "/")
            {
                answer = (double) a / b;
            }
            else
            {
                Console.WriteLine("Your choice of operator isn't valid.");
                return;
            }

            Console.WriteLine($" Your result is {answer}.");

        }
    }
}