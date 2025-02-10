using System; 
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("SA001", "John Doe", 1000.0),
            new CurrentAccount("CA001", "Jane Smith", 5000.0)
        };

        // Loop through each bank account
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Holder Name: " + account.HolderName);
            Console.WriteLine("Balance: $" + account.Balance);
            Console.WriteLine("Interest: $" + account.CalculateInterest());

            // Explicitly checking if the account implements ILoanable
            ILoanable loanable = account as ILoanable;
            if (loanable != null)
            {
                Console.WriteLine("Loan Eligibility: $" + loanable.CalculateLoanEligibility());
            }

            Console.WriteLine();
        }
    }
}

// Abstract base class for all bank accounts
public abstract class BankAccount
{
    // Private fields for encapsulation
    private string accountNumber;
    private string holderName;
    private double balance;

    // Constructor to initialize account details
    protected BankAccount(string accountNumber, string holderName, double initialBalance)
    {
        this.AccountNumber = accountNumber;
        this.HolderName = holderName;
        this.Balance = initialBalance;
    }

    // Public properties with validation
    public string AccountNumber
    {
        get { return accountNumber; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Account number cannot be empty");
            accountNumber = value;
        }
    }

    public string HolderName
    {
        get { return holderName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Holder name cannot be empty");
            holderName = value;
        }
    }

    public double Balance
    {
        get { return balance; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative");
            balance = value;
        }
    }

    // Method to deposit money
    public virtual void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive");
        Balance += amount;
    }

    // Method to withdraw money
    public virtual void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive");
        if (amount > Balance)
            throw new ArgumentException("Insufficient funds");
        Balance -= amount;
    }

    // Abstract method for interest calculation
    public abstract double CalculateInterest();
}

// Interface for loan-related operations
public interface ILoanable
{
    bool ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Savings account implementation
public class SavingsAccount : BankAccount, ILoanable
{
    // Private constant for interest rate
    private const double InterestRate = 0.045; // 4.5%

    // Constructor
    public SavingsAccount(string accountNumber, string holderName, double initialBalance)
        : base(accountNumber, holderName, initialBalance) { }

    // Implementation of abstract method
    public override double CalculateInterest()
    {
        return Balance * InterestRate;
    }

    // Implementation of interface methods
    public bool ApplyForLoan(double amount)
    {
        return amount <= CalculateLoanEligibility();
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 2; // Can loan up to 2x the balance
    }
}

// Current account implementation
public class CurrentAccount : BankAccount, ILoanable
{
    // Private constant for interest rate
    private const double InterestRate = 0.01; // 1%

    // Constructor
    public CurrentAccount(string accountNumber, string holderName, double initialBalance)
        : base(accountNumber, holderName, initialBalance) { }

    // Implementation of abstract method
    public override double CalculateInterest()
    {
        return Balance * InterestRate;
    }

    // Implementation of interface methods
    public bool ApplyForLoan(double amount)
    {
        return amount <= CalculateLoanEligibility();
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 1.5; // Can loan up to 1.5x the balance
    }
}
