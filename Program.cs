using System;

namespace Simple_App_For_Azure
{
    public class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            string loopSentinal = "y";
            string response;
            do
            {
                Console.Write("Enter number one: ");
                double numOne = GetValidDouble();

                Console.Write("Enter number two: ");
                double numTwo = GetValidDouble();

                Console.WriteLine("Choose a math function");
                Console.Write("(Addition/A), (Subtraction/S), (Multiplication/M), (Division/D): ");
                string func = Console.ReadLine().Trim().Substring(0, 1).ToLower();

                double result;
                switch (func)
                {
                    case "a":
                        result = Addition(numOne, numTwo);
                        Console.WriteLine(numOne + " + " + numTwo + " = " + result);
                        break;
                    case "s":
                        result = Subtraction(numOne, numTwo);
                        Console.WriteLine(numOne + " - " + numTwo + " = " + result);
                        break;
                    case "m":
                        result = Multiplication(numOne, numTwo);
                        Console.WriteLine(numOne + " * " + numTwo + " = " + result);
                        break;
                    case "d":
                        result = Division(numOne, numTwo);
                        Console.WriteLine(numOne + " / " + numTwo + " = " + result);
                        break;
                    default:
                        Console.WriteLine(func + " is not a valid function.");
                        break;
                }

                Console.Write("Do you want to close this program? (Y/N): ");
                response = Console.ReadLine().Trim().Substring(0, 1).ToLower();
            }
            while (response != loopSentinal);
            Console.Write("Press any key to exit ");
            Console.ReadKey();
        }
        public static double Addition(double numOne, double numTwo)
        {
            double result = numOne + numTwo;
            return result;
        }
        public static double Subtraction(double numOne, double numTwo)
        {
            double result = numOne - numTwo;
            return result;
        }
        public static double Multiplication(double numOne, double numTwo)
        {
            double result = numOne * numTwo;
            return result;
        }
        public static double Division(double numOne, double numTwo)
        {
            if (numOne != 0 && numTwo != 0)
            {
                double result = numOne / numTwo;
                return result;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero");
                return 0;
            }
        }
        public static double GetValidDouble()
        {
            try
            {
                double value = double.Parse(Console.ReadLine());
                return value;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
