
using System;

class Calculator
{
    static void Main()
    {
        double firstNumber, secondNumber;
        char operation;

        Console.Write("Enter first number: ");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /, %): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                Console.WriteLine("Result: " + (firstNumber + secondNumber));
                break;

            case '-':
                Console.WriteLine("Result: " + (firstNumber - secondNumber));
                break;

            case '*':
                Console.WriteLine("Result: " + (firstNumber * secondNumber));
                break;

            case '/':
                if (secondNumber != 0)
                {
                    Console.WriteLine("Result: " + (firstNumber / secondNumber));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                break;

            case '%':
                if (secondNumber != 0)
                {
                    Console.WriteLine("Remainder: " + (firstNumber % secondNumber));
                }
                else
                {
                    Console.WriteLine("Cannot find remainder with zero.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }
}
