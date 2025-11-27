public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property: AccountNumber (read-only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property: Balance (read-only outside class)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Balance cannot be negative or zero.");
            }
            balance = value;
        }
    }

    // Constructor — accountNumber and initial balance
    public BankAccount(string accNum, double initialBalance)
    {
        accountNumber = accNum;
        Balance = initialBalance;   // Uses property with validation
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited: {amount}");
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrawn: {amount}");
    }
}
