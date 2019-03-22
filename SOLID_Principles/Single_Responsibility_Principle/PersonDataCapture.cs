using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person Output = new Person();

            Console.Write("Enter your first name: ");
            Output.FirstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            Output.LastName = Console.ReadLine();

            return Output;
        }
    }
}
