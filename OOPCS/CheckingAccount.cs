namespace OOPCS;

public class CheckingAccount: BankAccount
{
    public CheckingAccount(string accountNo, float balance) : base(accountNo, balance)
    {
    }

    public override float GetDailyInterest()
    {
        return 0;
    }

    public override bool TransferToAccount(BankAccount account, float amt)
    {
        if (balance < amt || !Withdraw(amt))
        {
            return false;
        }
        account.Deposit(amt);
        return true;
    }
}