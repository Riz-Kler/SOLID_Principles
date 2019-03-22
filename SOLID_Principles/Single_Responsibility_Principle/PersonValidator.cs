using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // are names valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayErrorValidationError("first name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayErrorValidationError("last name");
                return false;
            }

                return true;
        }
    }
}
