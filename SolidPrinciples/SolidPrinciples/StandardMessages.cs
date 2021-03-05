using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples
{
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Advanced to C#");
        }

        public static void DisplayValidationError(string fieldname)
        {
            Console.WriteLine($"You did not give us a valid {fieldname}");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
