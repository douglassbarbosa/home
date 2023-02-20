﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a operator: ");
            var op = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = float.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine(number + number2);
                    break;
                case "-":
                    Console.WriteLine(number - number2);
                    break;
                case "*":
                    Console.WriteLine(number * number2);
                    break;
                case "/":
                    if ((int)number2 == 0)
                    {
                        Console.WriteLine("ERROR - Don't divisions for Zero");
                        break;
                    }
                    Console.WriteLine(number / number2);
                    break;
                case "%":
                    Console.WriteLine(number % number2);
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(number, number2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}