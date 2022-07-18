namespace OOPCS;

public class TestSavingsAccount
{
    static void Main(string[] args)
    {
        BankAccount account = new SavingsAccount("Sa-001", 0.0f);

        account.Deposit(100.0);
        account.Withdraw(50.0);

        Console.WriteLine("Balance: $" + account.GetBalance());
        Console.WriteLine("Daily Interest: $" + Math.Round(account.GetDailyInterest(), 3));
    }
}