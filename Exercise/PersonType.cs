namespace Exercise;

public class PersonType
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public PersonType(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public PersonType()
    {
        FirstName = "DEFAULT";
        LastName = "DEFAULT";
    }

    public override string ToString()
    {
        var res = "Firstname: " + FirstName + ", Lastname: " + LastName;
        return res;
    }
}