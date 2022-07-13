namespace OOPCS;

public class OverdraftAccount : Account
{
    private static readonly double interest = 0.0025;
    private static readonly double negativePay = 0.06;

    public OverdraftAccount(string acctNumber, string acctHolderId, double balance) : base(acctNumber, acctHolderId, balance)
    {
    }

    /**
     * The method return the interest of this account.
     * Overdraft Account earns 0.25% interest for positive 
     * balance and pays 6% interest for negative balance.
     * In the latter case, this method may return a 
     * negative number.
     */
    public override double CalculateInterest()
    {
        if (Balance >= 0) return Balance * interest;
        return Balance * negativePay;
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
     * This method decreases the account balance
     * by the given amount. 
     * For a Overdraft Account, balance can be negative
     */
    public new void Withdraw(double amt)
    {
        Balance -= amt;
        Console.WriteLine("Withdraw Successful");
        Console.WriteLine(ToString());
    }

    /**
     * This method returns the values of the attributes
     * of the current object in a more readable format
     */
    public override string ToString()
    {
        return "(OverdraftAccount) " + base.ToString();
    }
}