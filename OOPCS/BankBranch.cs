namespace OOPCS;

public class BankBranch
{
    //
    // This attributes keep a list of bank accounts.
    // Any type of accounts will be accepted
    // 
    private List<Account> _accounts;

    public List<Account> Accounts
    {
        get => _accounts;
        set => _accounts = value;
    }

    public BankBranch(string name)
    {
        Name = name;
        _accounts = new List<Account>();
    }

    // Auto-properties
    public string Name { get; set; }

    /**
     * This method helps this bank branch keeps another
     * bank account, by adding a given Account object to the
     * _accounts list.
     */
    public void AddAccount(Account account)
    {
        _accounts.Add(account);
    }

    /**
     * This method prints the information of all 
     * the accounts' that this branch keeps
     */
    public void PrintAccounts()
    {
        _accounts.ForEach(Console.WriteLine);
    }

    /**
     * This method returns the total non-negative
     * balance of all accounts that this branch
     * keeps
     */
    public double TotalDeposits()
    {
        return _accounts.Where(account => account.Balance > 0).Sum(account => account.Balance);
    }

    /**
     * Every year, each account which has 
     * non-negative balance kept in this branch
     * will be paid its respective interest, computed
     * by the account's CalculateInterest() method
     * 
     * This method returns the sum of  
     * interests that this branch pays to 
     * all non-negative balance accounts it keeps 
     */
    public double TotalInterestPaid()
    {
        return _accounts.Where(acc => acc.Balance > 0).Sum(acc => acc.CalculateInterest());
    }

    /**
     * Every year, each account which has
     * negative balance will pay its respective 
     * interest, computed by the account's 
     * CalculateInterest() method
     * 
     * This method returns the sum of negative 
     * interests that this branches earns from 
     * all negative-balance accounts it keeps 
     */
    public double TotalInterestEarned()
    {
        return _accounts.Where(acc => acc.Balance < 0).Sum(acc => acc.CalculateInterest()) * -1;
    }

    /**
     * TODO: Implement method PrintCustomers()
     * 
     * As we know, each account has attribute
     * to keep the respective holder id
     * 
     * This method prints all UNIQUE holder ids
     * of all accounts that this branch keeps.
     * Note that a customer can hold multiple
     * accounts
     * 
     */
    public void PrintCustomers()
    {
        _accounts.DistinctBy(acc => new {acc.AcctHolderId}).ToList().ForEach(Console.WriteLine);
    }
}