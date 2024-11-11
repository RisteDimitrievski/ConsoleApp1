using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please introduce yourself. My name is [Bot] Alfred.");
            Console.Write("What is your name: ");

            // Get the user's name
            string userName;
            while (true)
            {
                userName = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userName))
                {
                    break;
                }

                Console.WriteLine("Please enter your name:");
            }

            Console.WriteLine($"Nice to meet you, {userName}. Please enter your birthdate (format: MM/dd/yyyy):");

            DateTime birthdate;

            // Loop until the user enters a valid date
            while (true)
            {
                string bday = Console.ReadLine();

                // Attempt to convert the string to DateTime
                if (DateTime.TryParse(bday, out birthdate))
                {
                    // Check if the birthdate is in the future
                    if (birthdate > DateTime.Now)
                    {
                        Console.WriteLine("Birthdate cannot be in the future. Please enter a valid birthdate:");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter your birthdate in MM/dd/yyyy format:");
                }
            }

            Console.WriteLine($"Thank you, {userName}. Your birthdate is: {birthdate.ToShortDateString()} and you have {DateTime.Now.Year - birthdate.Year} years.");

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
