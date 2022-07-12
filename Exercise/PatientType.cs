namespace Exercise;

public class PatientType : PersonType
{
    public string PatientId { get; set; }
    public int PatientAge { get; set; }
    public DateType DateOfBirth { get; set; }
    public DoctorType Physician { get; set; }
    public DateType DateAdmitted { get; set; }
    public DateType DateDischarged { get; set; }

    public PatientType(string firstName, string lastName, string patientId, int patientAge, DateType dateOfBirth, DoctorType physician, DateType dateAdmitted, DateType dateDischarged) : base(firstName, lastName)
    {
        PatientId = patientId;
        PatientAge = patientAge;
        DateOfBirth = dateOfBirth;
        Physician = physician;
        DateAdmitted = dateAdmitted;
        DateDischarged = dateDischarged;
    }

    public PatientType(string patientId, int patientAge, DateType dateOfBirth, DoctorType physician, DateType dateAdmitted, DateType dateDischarged)
    {
        PatientId = patientId;
        PatientAge = patientAge;
        DateOfBirth = dateOfBirth;
        Physician = physician;
        DateAdmitted = dateAdmitted;
        DateDischarged = dateDischarged;
    }

    public PatientType()
    {
        PatientId = "#00DEFAULT";
        PatientAge = 0;
        DateOfBirth = new DateType();
        Physician = new DoctorType();
        DateAdmitted = new DateType();
        DateDischarged = new DateType();
    }

    public override string ToString()
    {
        var res = "PatientId: " + PatientId + ", PatientAge" + PatientAge;
        res += ", DateOfBirth: " + DateOfBirth;
        res += ", Physician: [" + Physician;
        res += "], DateAdmitted: " + DateAdmitted;
        res += ", DateDischarged: " + DateDischarged;

        return res;
    }
}