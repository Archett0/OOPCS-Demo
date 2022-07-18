namespace OOPCS;

public abstract class BankAccount
{
    protected string accountNo;
    protected double balance;

    public BankAccount(string accountNo, double balance)
    {
        this.accountNo = accountNo;
        this.balance = balance;
    }

    public double GetBalance()
    {
        return balance;
    }

    public void Deposit(double amt)
    {
        if (amt > 0)
        {
            balance += amt;
        }
    }

    public bool Withdraw(double amt)
    {
        if (amt <= 0 || balance < amt) return false;
        balance -= amt;
        return true;
    }

    public abstract double GetDailyInterest();
    public abstract bool TransferToAccount(BankAccount account, double amt);
}