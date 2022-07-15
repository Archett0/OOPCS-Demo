namespace Quiz;

public class Park
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string TypeOfPark { get; set; }
    public string Facility { get; set; }
    public double Fee { get; set; }
    public int NumberOfEmployees { get; set; }
    public int NumberOfVisitorsInLast12Months { get; set; }
    public double AnnualBudget { get; set; }

    public Park(string name, string location, string typeOfPark, string facility, double fee, int numberOfEmployees, int numberOfVisitorsInLast12Months, double annualBudget)
    {
        Name = name;
        Location = location;
        TypeOfPark = typeOfPark;
        Facility = facility;
        Fee = fee;
        NumberOfEmployees = numberOfEmployees;
        NumberOfVisitorsInLast12Months = numberOfVisitorsInLast12Months;
        AnnualBudget = annualBudget;
    }

    public string GetNameLocationAndType()
    {
        return "Name: " + Name + ", Location: " + Location + ", Type: " + TypeOfPark;
    }

    public string GetNameLocationAndFacility()
    {
        return "Name: " + Name + ", Location: " + Location + ", Facility: " + Facility;
    }

    public double GetCostPerVisitor()
    {
        return AnnualBudget / NumberOfVisitorsInLast12Months;
    }

    public double GetRevenue()
    {
        return NumberOfVisitorsInLast12Months * Fee;
    }

    public override string ToString()
    {
        return "Name: " + Name + ", Location: " + Location + ", TypeOfPark: " + TypeOfPark
               + ", Facility: " + Facility+ ", Fee: " + Fee + ", NumberOfEmployees: " + NumberOfEmployees
               + ", NumberOfVisitorsInLast12Months: " + NumberOfVisitorsInLast12Months + ", AnnualBudget: " + AnnualBudget;
    }
}