using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Menu();
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Result " + number + " + " + number2 + " = " + (number + number2));

            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Result " + number + " - " + number2 + " = " + (number - number2));

            Console.ReadKey();
            Menu();
        }
        static void Multip()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Result " + number + " * " + number2 + " = " + (number * number2));

            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            if ((int)number2 == 0)
            {
                Console.WriteLine("ERROR - Don't divisions for Zero");

                Console.ReadKey();
                Menu();
            }
            Console.WriteLine("Result " + number + " / " + number2 + " = " + (number / number2));

            Console.ReadKey();
            Menu();
        }

        static void Module()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            if ((int)number2 == 0)
            {
                Console.WriteLine("ERROR - Don't divisions for Zero");

                Console.ReadKey();
                Menu();
            }
            Console.WriteLine("");
            Console.WriteLine("Result " + number + " % " + number2 + " = " + (number % number2));

            Console.ReadKey();
            Menu();
        }
        static void Power()
        {
            Console.Clear();
            Console.WriteLine("Enter a value 1: ");
            var number = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a value 2: ");
            var number2 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Result " + number + " ^ " + number2 + " = " + (Math.Pow(number, number2)));
            Console.ReadKey();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Module");
            Console.WriteLine("6. Power");
            Console.WriteLine("0. Quit");
            Console.WriteLine("");
            Console.WriteLine(" ----------- ");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice: ");

            short choice = short.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Multip(); break;
                case 4: Division(); break;
                case 5: Module(); break;
                case 6: Power(); break;
                case 0: System.Environment.Exit(0); break;
                default:
                    Console.WriteLine("Invalid choice. Try Again!");
                    break;
            }

        }
    }
}