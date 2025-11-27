class Program
{
    static void Main(string[] args)
    {
        // Create bank account object
        BankAccount account = new BankAccount("ACC1001", 5000);

        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Initial Balance: " + account.Balance);

        // Deposit
        account.Deposit(1500);

        // Withdraw
        account.Withdraw(2000);

        // Print remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);
    }
}
