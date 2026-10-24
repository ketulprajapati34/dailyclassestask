
using System;

namespace MyPersonalDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Ketul prajapati";
            int age = 22;
            char gender = 'M';
            double height = 5.8;
            float weight = 62.5f;
            decimal monthlySalary = 5500.50m;
            bool isStudent = false;
            long phoneNumber = 9876543210L;
            byte luckyNumber = 7;
            short birthYear = 2004;
            uint pinCode = 305001;

            Console.WriteLine("=============================== PERSONAL DETAILS ===============================");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Monthly Salary: " + monthlySalary);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Lucky Number: " + luckyNumber);
            Console.WriteLine("Birth Year: " + birthYear);
            Console.WriteLine("PIN Code: " + pinCode);
            Console.WriteLine("=============================== PERSONAL DETAILS ===============================");


        }
    }
}
