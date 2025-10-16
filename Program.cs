using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_App_For_Azure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loopSentinal = "y";
            string response;
            do
            {
                Console.Write("Enter the first number: ");
                double numberOne = double.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double numberTwo = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose your function");
                Console.Write("(Addition/A), (Subtraction/S), (Multiplication/M), (Division/D): ");
                string function = Console.ReadLine().Trim().Substring(0, 1).ToLower();

                switch (function)
                {
                    case "a":
                        double result = Addition(numberOne, numberTwo);
                        Console.WriteLine(numberOne.ToString() + " + " + numberTwo.ToString() + " = " + result.ToString());
                        break;
                    case "s":
                        result = Subtraction(numberOne, numberTwo);
                        Console.WriteLine(numberOne.ToString() + " - " + numberTwo.ToString() + " = " + result.ToString());
                        break;
                    case "m":
                        result = Multiplication(numberOne, numberTwo);
                        Console.WriteLine(numberOne.ToString() + " * " + numberTwo.ToString() + " = " + result.ToString());
                        break;
                    case "d":
                        result = Division(numberOne, numberTwo);
                        Console.WriteLine(numberOne.ToString() + " / " + numberTwo.ToString() + " = " + result.ToString());
                        break;
                    default:
                        Console.WriteLine(function + " is not a valid function");
                        break;
                }

                Console.Write("Do you want to close this program? (Y/N): ");
                response = Console.ReadLine().Trim().Substring(0, 1).ToLower();
            } 
            while (response != loopSentinal);
            Console.Write("Press any key to exit ");
            Console.ReadKey();
        }
        static double Addition(double numberOne, double numberTwo)
        {
            double result = numberOne + numberTwo;
            return result;
        }
        static double Subtraction(double numberOne, double numberTwo)
        {
            double result = numberOne - numberTwo;
            return result;
        }
        static double Multiplication(double numberOne, double numberTwo)
        {
            double result = numberOne * numberTwo;
            return result;
        }
        static double Division(double numberOne, double numberTwo)
        {
            if (numberOne != 0 && numberTwo != 0)
            {
                double result = numberOne / numberTwo;
                return result;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
        }
    }
}
