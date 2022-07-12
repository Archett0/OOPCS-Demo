namespace OOPCS;

public class Account
{
    public string AcctNumber { get; }
    public string AcctHolderId { get; set; }
    public double Balance { get; set; }

    public Account(string acctNumber, string acctHolderId, double balance)
    {
        AcctNumber = acctNumber;
        AcctHolderId = acctHolderId;
        Balance = balance;
    }

    public void Withdraw(double amt)
    {
        if (Balance - amt >= 0)
        {
            Balance -= amt;
            Console.WriteLine("Withdraw Successful");
            Console.WriteLine(ToString());
            return;
        }
        Console.WriteLine("Withdraw Failed");
    }

    public void Deposit(double amt)
    {
        Balance += amt;
        Console.WriteLine("Deposit Successful");
        Console.WriteLine(ToString());
    }

    public void TransferTo(double amt, Account another)
    {
        if (!(Balance - amt >= 0))
        {
            Console.WriteLine("Transfer Failed");
            return;
        }
        Balance -= amt;
        another.Balance += amt;
        Console.WriteLine("Transfer Successful");
        Console.WriteLine(ToString());
        Console.WriteLine(another.ToString());
    }

    public override string ToString()
    {
        return "Account: " + "AccountNbr: " + AcctNumber + ", AcctHolderId: " + AcctHolderId + ", Balance: " + Balance;
    }
}