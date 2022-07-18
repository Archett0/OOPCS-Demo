namespace OOPCS;

public class TestSavingsAccount
{
    static void Main(string[] args)
    {
        BankAccount savingsAccount = new SavingsAccount("Sa-001", 100.0f);
        BankAccount checkingAccount = new CheckingAccount("CA-001", 500.0f);

        checkingAccount.TransferToAccount(savingsAccount, 200.0f);

        // savingsAccount.Deposit(100.0);
        // savingsAccount.Withdraw(50.0);

        Console.WriteLine("Savings Balance: $" + savingsAccount.GetBalance());
        Console.WriteLine("Checking Balance: $" + checkingAccount.GetBalance());
        Console.WriteLine("Daily Interest: $" + Math.Round(checkingAccount.GetDailyInterest(), 3));
    }
}