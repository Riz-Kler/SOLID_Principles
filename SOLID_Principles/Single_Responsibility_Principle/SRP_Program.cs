using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    class SRP_Program
    {

        // A class or method should have 1 and only 1 reason to change. Bad code was amended to follow SRP!

        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture(); // this is tightly coupled will be corrected in another principle

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreatAccount(user);

            StandardMessages.EndApplication();
        }
    }
}