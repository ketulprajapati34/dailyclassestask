
using System;

class StatementsAndLoops
{
    static void Main()
    {
        // If-else statement
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are not eligible to vote.");
        }

        // Switch statement
        Console.Write("Enter a number from 1 to 3: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You selected One.");
                break;

            case 2:
                Console.WriteLine("You selected Two.");
                break;

            case 3:
                Console.WriteLine("You selected Three.");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }

        // For loop
        Console.WriteLine("\nFor Loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // While loop
        Console.WriteLine("\nWhile Loop:");
        int j = 1;

        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        // Do-while loop
        Console.WriteLine("\nDo-While Loop:");
        int k = 1;

        do
        {
            Console.WriteLine(k);
            k++;
        }
        while (k <= 5);
    }
}
