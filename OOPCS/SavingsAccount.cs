namespace OOPCS;

public class SavingsAccount : BankAccount
{
    protected static double interest;

    public SavingsAccount(string acctNumber, float balance) : base(acctNumber, balance)
    {
        interest = 0.03f;
    }

    public override float GetDailyInterest()
    {
        return (float)((interest / 365) * balance);
    }

    public override bool TransferToAccount(BankAccount account, float amt)
    {
        return false;
    }

}