namespace OOPCS;

public class Manager: Employee
{
    public string DepartmentName { get; set; }

    public Manager(string departmentName) : base()
    {
        DepartmentName = departmentName;
    }

    public new void PrintDetails()
    {
        base.PrintDetails();
        Console.WriteLine("DepartmentName: " + DepartmentName);
    }

}