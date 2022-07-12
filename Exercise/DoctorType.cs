namespace Exercise;

public class DoctorType : PersonType
{
    public string Speciality { get; set; }

    public DoctorType(string firstName, string lastName, string speciality) : base(firstName, lastName)
    {
        Speciality = speciality;
    }

    public DoctorType(string speciality)
    {
        Speciality = speciality;
    }

    public DoctorType()
    {
        Speciality = "DEFAULT";
    }

    public override string ToString()
    {
        var res = base.ToString() + ", Speciality: " + Speciality;
        return res;
    }
}