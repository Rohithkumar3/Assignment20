using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            Console.WriteLine("Hello World!");
            //Task-2 
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name}");

            //Task-3
            int num1, num2;
            Console.Write("\nEnter First Number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            num2 = int.Parse(Console.ReadLine());

            int Add = num1 + num2;
            Console.WriteLine($"Add: {Add}");

            int sub = num1 - num2;
            Console.WriteLine($"Sub: {sub}");

            int product = num1 * num2;
            Console.WriteLine($"Mult: {product}");

            if (num2 != 0)
            {
                double Divisionn = (double)num1 / num2;
                Console.WriteLine($"Div: {Divisionn}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            if (num2 != 0)
            {
                int remainder = num1 % num2;
                Console.WriteLine($"Remainder: {remainder}");
            }
            else
            {
                Console.WriteLine("Cannot calculate remainder when dividing by zero.");
            }

            //Task-4 Control Structures
            Console.WriteLine("\nEnter a Number to check Even or Odd ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even Number");
            }
            else
            {
                Console.WriteLine($"{num} is Odd Number");
            }

            //Task-5 Loops
            Console.WriteLine("\nPrint Numbers from 1 to 10");
            for (int i= 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //Task-6 Arrays
            int[] array = { 12, 6, 8, 3, 6 };
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            double avg = (double)sum / array.Length;
            Console.WriteLine("\nArray Elements are: " + string.Join(" ", array));
            Console.WriteLine($"Sum is Elements is {sum}");
            Console.WriteLine($"Avg is Elements is {avg}");

            //Task-7 Methods
            Console.Write("\nEnter a positive integer to calculate its factorial: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {input}: {CalculateFactorial(input)}");

            int CalculateFactorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalculateFactorial(n - 1);
                }
            }

            //Task-8 Exception Handling
            int age;
            Console.Write("\nEnter Age: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine(age);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for age");
                }
            }
            if (age < 18)
            {
                Console.WriteLine("Person is Minor");
            }
            else if(age >= 18 && age <= 65)
            {
                Console.WriteLine("Person is adult");
            }
            else
            {
                Console.WriteLine("Person is Senior");
            }

            Console.ReadKey();
        }
    }
}

