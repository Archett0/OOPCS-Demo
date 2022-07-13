namespace OOPCS;

public class Test
{
    static void Main(string[] args)
    {
        // Test Saving Accounts

        SavingsAccount savingAccount = new SavingsAccount("S0000111", "S1111111A", 2000);
        Console.WriteLine(savingAccount.ToString());
        Console.WriteLine("Interest: {0}", savingAccount.CalculateInterest());
        savingAccount.CreditInterest();
        Console.WriteLine(savingAccount.ToString());
        savingAccount.Withdraw(3000);
        Console.WriteLine();



        // Test Current Accounts

        CurrentAccount currentAccount = new CurrentAccount("S0000333", "S3333333B", 2000);
        Console.WriteLine(currentAccount.ToString());
        Console.WriteLine("Interest: {0}", currentAccount.CalculateInterest());
        currentAccount.CreditInterest();
        Console.WriteLine(currentAccount.ToString());
        currentAccount.Withdraw(3000);
        Console.WriteLine();



        // Test Overdraft Accounts

        OverdraftAccount overdraftAccount1 = new OverdraftAccount("S0000222", "S2222222B", 2000);
        Console.WriteLine(overdraftAccount1.ToString());
        Console.WriteLine("Interest: {0}", overdraftAccount1.CalculateInterest());
        overdraftAccount1.CreditInterest();
        Console.WriteLine(overdraftAccount1.ToString());
        overdraftAccount1.Withdraw(3000);
        Console.WriteLine();

        OverdraftAccount overdraftAccount2 = new OverdraftAccount("S0000222", "S2222222B", -2000);
        Console.WriteLine(overdraftAccount2.ToString());
        Console.WriteLine("Interest: {0}", overdraftAccount2.CalculateInterest());
        overdraftAccount2.CreditInterest();
        Console.WriteLine(overdraftAccount2.ToString());
        Console.WriteLine();
    }
}