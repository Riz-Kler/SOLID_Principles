using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public class ExecutiveAccounts : IAccounts
    {
        public Employee Create(IApplicantModel person)
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }.{ person.LastName}@acmecorp.com";

            output.IsManager = true;
            output.IsExecutive = true;
            return output;
        }
    }
}
