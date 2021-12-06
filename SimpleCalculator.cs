// Simple calculator made by Sh0w3D # Kamil Oberaj
// Created in .NET 5.0
using System;

namespace SimpleCalculator
{
    class Program
    {

        static void displayOptions()
        {
            Console.WriteLine("There are available options:");
            Console.WriteLine(new string(' ', 2) + "1 > Add");
            Console.WriteLine(new string(' ', 2) + "2 > Subtract");
            Console.WriteLine(new string(' ', 2) + "3 > Multiply");
            Console.WriteLine(new string(' ', 2) + "4 > Divide");
            Console.WriteLine(new string(' ', 2) + "e > Exit");
            Console.Write("Choose one: ");
        }
        static double makeCalculations(string symbol, double x, double y)
        {
            double result = double.NaN;
            switch (symbol)
            {
                case "1":
                    result = x + y;
                    break;

                case "2":
                    result = x - y;
                    break;

                case "3":
                    result = x * y;
                    break;

                case "4":
                    if(x == 0.0 || y == 0.0)
                    {
                        Console.WriteLine("Error, you can't divide by 0!");
                        result = 0;
                        break;
                    } else
                    {
                        result = x / y;
                        break;
                    }
                default:
                    Environment.Exit(0);
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            displayOptions();
            double firstNumber, secondNumber, finish;
            string chosenOption = Console.ReadLine();
            if(chosenOption == "e")
            {
                Environment.Exit(0);
            }

            Console.Clear();
            Console.WriteLine("Your option: " + chosenOption);

            Console.Write("Please input first number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            finish = makeCalculations(chosenOption, firstNumber, secondNumber);
            Console.WriteLine("Your calculations: " + finish);
        }
    }
}
