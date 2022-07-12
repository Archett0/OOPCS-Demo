namespace OOPCS
{
    public class Program
    {
        // public static void ChangeName(Student student)
        // {
        //     Console.WriteLine();
        //     student.Name = "New Name";
        //     Console.WriteLine();
        // }
        //
        // public static void RefDemo(ref int num)
        // {
        //     num++;
        // }
        //
        // static void Main(string[] args)
        // {
        //     // Student student = new Student("Song");
        //     // Console.WriteLine("Before: " + student.Name);
        //     // ChangeName(student);
        //     // Console.WriteLine("After: " + student.Name);
        //     //
        //     int num = 0;
        //     Console.WriteLine(num);
        //     RefDemo(ref num);
        //     Console.WriteLine(num);
        // }
        static void Main(string[] args)
        {
            // Account accountB = new Account("2", "2", 0);
            // accountA.Withdraw(200);
            // accountA.Withdraw(50);
            // accountB.Withdraw(50);
            // accountB.Deposit(100);
            // accountA.TransferTo(200, accountB);
            // accountA.TransferTo(25, accountB);
            //
            // Test class Account by creating an Account object
            // and call methods to make sure your code at 
            // class Account work


            // TODO. Create object
            // 1. Create a new Account object account1
            // - accNumber: S0000111
            // - acctHolderId: S1111111A
            // - balance: 2000
            // 2. Call Console.WriteLine(account1)
            // Make sure that the account information 
            // is displayed correctly
            Account account1 = new Account("S0000111", "S1111111A", 2000);
            Console.WriteLine(account1);


            // TODO: Deposit
            // Deposit 200 to the acccount.
            // Display the account information again and 
            // manually verify the new balance
            account1.Deposit(200);


            // TODO: Widthdraw
            // Withdraw 200 from the account.
            // Display the account information again and
            // manually verify the new balance
            account1.Withdraw(200);


            // TODO: Widthdraw
            // Withdraw 4000 from the account.
            // Make sure that the withdrawing is unsuccessful.
            account1.Withdraw(4000);
        }
    }
}
