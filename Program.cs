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
                Console.Write("Do you want to close this program? (Y/N): ");
                response = Console.ReadLine().Trim().Substring(0, 1).ToLower();
            } 
            while (response != loopSentinal);
            Console.Write("Press any key to exit ");
            Console.ReadKey();
        }
    }
}
