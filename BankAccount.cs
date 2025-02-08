using System;

// Base class representing a general Bank Account
class BankAccount
{
    public int AccountNumber { get; set; }  // Stores the account number
    public double Balance { get; set; }  // Stores the account balance

    // Method to display account details
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("This is a generic bank account.");
    }
}

// SavingsAccount class inherits from BankAccount
class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }  // Stores the interest rate

    // Overriding DisplayAccountType() to specify Savings Account
    public override void DisplayAccountType()
    {
        Console.WriteLine($"Savings Account - Interest Rate: {InterestRate}%");
    }
}

// CheckingAccount class inherits from BankAccount
class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }  // Stores the withdrawal limit

    // Overriding DisplayAccountType() to specify Checking Account
    public override void DisplayAccountType()
    {
        Console.WriteLine($"Checking Account - Withdrawal Limit: ${WithdrawalLimit}");
    }
}

// FixedDepositAccount class inherits from BankAccount
class FixedDepositAccount : BankAccount
{
    public int MaturityPeriod { get; set; }  // Stores the maturity period in months

    // Overriding DisplayAccountType() to specify Fixed Deposit Account
    public override void DisplayAccountType()
    {
        Console.WriteLine($"Fixed Deposit Account - Maturity Period: {MaturityPeriod} months");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of different account types
        SavingsAccount savings = new SavingsAccount { AccountNumber = 1001, Balance = 5000, InterestRate = 4.5 };
        CheckingAccount checking = new CheckingAccount { AccountNumber = 1002, Balance = 3000, WithdrawalLimit = 2000 };
        FixedDepositAccount fixedDeposit = new FixedDepositAccount { AccountNumber = 1003, Balance = 10000, MaturityPeriod = 12 };

        // Displaying account types
        savings.DisplayAccountType();
        checking.DisplayAccountType();
        fixedDeposit.DisplayAccountType();
    }
}
