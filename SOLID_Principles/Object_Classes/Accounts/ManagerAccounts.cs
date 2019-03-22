using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class ManagerAccounts : IAccounts //Through the use of interfaceIAccounts  ManagerAccounts becomes a copy of Accounts
    {                                          // By Avoiding use of Inheritance through Base classes and inheritance we can vary the email etc but similar logic
        public Employee Create(IApplicantModel person)
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@acmecorp.com";

            output.IsManager = true;

            return output;
        }
    }
}
