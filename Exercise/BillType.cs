namespace Exercise;

public class BillType
{
    public string Id { get; set; }
    public double PharmacyCharges { get; set; }
    public double DoctorsFee { get; set; }
    public double RoomCharges { get; set; }

    public BillType(string id, double pharmacyCharges, double doctorsFee, double roomCharges)
    {
        Id = id;
        PharmacyCharges = pharmacyCharges;
        DoctorsFee = doctorsFee;
        RoomCharges = roomCharges;
    }

    public BillType()
    {
        Id = "#000000DEFAULT";
        PharmacyCharges = 0;
        DoctorsFee = 0;
        RoomCharges = 0;
    }

    public override string ToString()
    {
        var res =
            "Id: " + Id +
            ", PharmacyCharges" + PharmacyCharges +
            ", DoctorsFee" + DoctorsFee +
            ", RoomCharges" + RoomCharges;
        return res;
    }
}