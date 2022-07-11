namespace OOPCS;

public class Person
{
    private string Name { get; set; }
    private string Gender { get; set; }
    private int Age { get; set; }
    private double Height { get; set; }

    protected date11 DOB { get; set; }

    public Person(string name, string gender, int age, double height)
    {
        Name = name;
        Gender = gender;
        Age = age;
        Height = height;
    }

    public Person(string name)
    {
        Name = name;
        Gender = "Male";
    }

    public Person(string name, date11 dob)
    {
        Name = name;
        Gender = "Male";
        DOB = new date11(dob);
    }

    public Person()
    {
        Name = "DEFAULT";
        Gender = "Male";
        Age = 30;
        Height = 1.8;
        DOB = new date11(1, 1, 2000);
    }

    public void Eat()
    {
        Console.WriteLine(Name + " is eating...");
    }

    public void Talk()
    {
        Console.WriteLine(Name + " is talking...");
    }

    public void Sleep()
    {
        Console.WriteLine(Name + " is sleeping...");
    }

    public void Drink()
    {
        Console.WriteLine(Name + " is drinking...");
    }

    public string GetName()
    {
        return Name;
    }

    public string GetGender()
    {
        return Gender;
    }

    public int GetAge()
    {
        return Age;
    }

    public double GetHeight()
    {
        return Height;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetGender(string gender)
    {
        Gender = gender;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void SetHeight(double height)
    {
        Height = height;
    }

    public void PrintDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Gender: " + Gender);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Height: " + Height);
        DOB.PrintDateDetails();
    }

}