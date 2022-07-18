namespace OOPCS;

public abstract class BankAccount
{
    protected string accountNo;
    protected float balance;

    public BankAccount(string accountNo, float balance)
    {
        this.accountNo = accountNo;
        this.balance = balance;
    }

    public float GetBalance()
    {
        return balance;
    }

    public void Deposit(float amt)
    {
        if (amt > 0)
        {
            balance += amt;
        }
    }

    public bool Withdraw(float amt)
    {
        if (amt <= 0 || balance < amt) return false;
        balance -= amt;
        return true;
    }

    public abstract float GetDailyInterest();
    public abstract bool TransferToAccount(BankAccount account, float amt);
}