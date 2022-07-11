namespace OOPCS;

public class Employee: Person
{
    public int EmployeeId { get; set; }
    public string MailBoxId { get; set; }

    public Employee(string name, string gender, int age, double height, int employeeId, string mailBoxId) : base(name, gender, age, height)
    {
        EmployeeId = employeeId;
        MailBoxId = mailBoxId;
    }

    public Employee(string name, int employeeId, string mailBoxId) : base(name)
    {
        EmployeeId = employeeId;
        MailBoxId = mailBoxId;
    }

    public Employee(int employeeId, string mailBoxId) : base()
    {
        EmployeeId = employeeId;
        MailBoxId = mailBoxId;
    }

    public Employee() : base()
    {
        EmployeeId = -1;
        MailBoxId = "Mail00";
    }

    public new void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("EmployeeID: " + EmployeeId);
        Console.WriteLine("MailBoxID: " + MailBoxId);
    }
}