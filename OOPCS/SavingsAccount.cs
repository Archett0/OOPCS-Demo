namespace OOPCS;

public class SavingsAccount : BankAccount
{
    protected static double interest;

    public SavingsAccount(string acctNumber, double balance) : base(acctNumber, balance)
    {
        interest = 0.03f;
    }

    public override double GetDailyInterest()
    {
        return (interest / 365) * balance;
    }

    public override bool TransferToAccount(BankAccount account, double amt)
    {
        return false;
    }

    /**
     * This method returns the values of the attributes
     * of the current object in a more readable format
     */
    public override string ToString()
    {
        return "(SavingsAccount) " + base.ToString();
    }
}