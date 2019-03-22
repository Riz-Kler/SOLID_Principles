using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class AccountGenerator
    {
        public static void CreatAccount(Person user)
        {
            // Creat username for person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0, 1)}{ user.LastName}");
        }
    }
}
