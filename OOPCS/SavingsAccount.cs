namespace OOPCS;

public class SavingsAccount : Account
{
    private static readonly double interest = 0.01;

    public SavingsAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance)
    {
    }

    /**
     * The method return the interest of this account.
     * Savings Account earns 1% interest of its balance.
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
        return "(SavingsAccount) " + base.ToString();
    }
}