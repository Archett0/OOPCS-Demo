namespace OOPCS;

public class Manager: Employee
{
    public string DepartmentName { get; set; }


    public Manager(string name, string gender, int age, double height, int employeeId, string mailBoxId, string departmentName) : base(name, gender, age, height, employeeId, mailBoxId)
    {
        DepartmentName = departmentName;
    }

    public Manager(string name, int employeeId, string mailBoxId, string departmentName) : base(name, employeeId, mailBoxId)
    {
        DepartmentName = departmentName;
    }

    public Manager(int employeeId, string mailBoxId, string departmentName) : base(employeeId, mailBoxId)
    {
        DepartmentName = departmentName;
    }

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