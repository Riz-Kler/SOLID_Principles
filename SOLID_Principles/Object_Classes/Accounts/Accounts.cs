using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace SOLIDLibrary
//{
    public class Accounts : IAccounts

//       OCP says a class should be closed for modification but open for extension
// DO NOT TIE YOURSELF DIRECTLY TO CLASSES  USE INTERFACES
{
        public Employee Create(IApplicantModel person)
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName}@acme.com";

        return output;
        }
    }
//}
