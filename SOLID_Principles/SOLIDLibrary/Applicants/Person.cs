using System.Collections.Generic;
using System;

    public class Person : IApplicantModel
{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts(); //Firm implementation of the IAccounts Interface

}
