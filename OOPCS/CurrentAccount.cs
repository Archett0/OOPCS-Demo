namespace OOPCS;

public class CurrentAccount : Account
{
    private static readonly double interest = 0.0025;

    public CurrentAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance)
    {
    }

    /**
     * The method return the interest of this account.
     * Current Account earns 0.25% interest of its balance.
     */
    public override double CalculateInterest()
    {
        return Balance * interest;
    }

    /**
     * The method deposit the interest amount, returns by
     * CalculateInterest() method of this
     * account to its balance.
     */
    public override void CreditInterest()
    {
        Balance += CalculateInterest();
    }

    /**
     * This method returns the values of the attributes
     * of the current object in a more readable format
     */
    public override string ToString()
    {
        return "(CurrentAccount) " + base.ToString();
    }
}