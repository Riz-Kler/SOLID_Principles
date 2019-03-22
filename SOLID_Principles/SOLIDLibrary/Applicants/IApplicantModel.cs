public interface IApplicantModel
{
    string FirstName { get; set; }
    string LastName { get; set; }
    IAccounts AccountProcessor { get; set; } // As this is a public interface it can be used within anither interface

}