using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    class OCP_Program
    
    {
        static void Main(string[] args)
        {
            //          List<Person> applicants = new List<Person>

 //           List<Person> applicants = new List<Person>    //This old pice of code can be replaced with the new Interface version, below.
 // This means that all of the extra functionality can be implemented and included by OCP.... EXTENSION NOT CHANGE!!!

            List<IApplicantModel> applicants = new List<IApplicantModel>

            // By using the IApplicantModel Interfacetype instead of Person type you can have ANYTYPE of person that implements the IApplicantModel type.

            {
                new ManagerModel { FirstName = "Riz", LastName = "Kler" },
                new ExecutiveModel { FirstName = "Cindy", LastName = "Crawford" },
                new Person { FirstName = "Ann", LastName = "Smith" }
            };

        List<Employee> employees = new List<Employee>();
    //    Accounts accountProcessor = new Accounts();   This is now implemented in Person as an IAccounts Interface

        foreach (var person in applicants)
            {
                //              employees.Add(accountProcessor.Create(person));
                employees.Add(person.AccountProcessor.Create(person)); //The above line can be re-written & AccountProcessor is an Interface
            }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: {emp.IsManager} IsExecutive: { emp.IsExecutive }");
        }

Console.ReadLine();

        }
    }
}
