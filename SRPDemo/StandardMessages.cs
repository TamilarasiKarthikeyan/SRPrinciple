using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPDemo
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Singel Responsibility Principle of SOLID Principles");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayErrorMessages(string fieldName)
        {
            Console.WriteLine($"Please enter your valid {fieldName}");
        }
    }
}
