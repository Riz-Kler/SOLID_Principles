using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {


            Console.WriteLine("Welcome to my application");
        }
        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();

        }
        public static void DisplayErrorValidationError(string fieldName)
        {
            Console.WriteLine($"You did not enter a valid { fieldName }!");
        }
    }
}
