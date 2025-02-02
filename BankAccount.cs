
using System;

class BankAccount
{
    public string AccountNumber { get; set; }
    protected string AccountHolder { get; set; }
    private double Balance;

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient balance.");
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }

    public void Display()
    {
        Console.WriteLine($"Savings Account: {AccountNumber}, Holder: {AccountHolder}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("ACC123", "Alice", 5000);
        account.Deposit(2000);
        Console.WriteLine($"Balance: {account.GetBalance()}");

        SavingsAccount savings = new SavingsAccount("SAV456", "Bob", 10000);
        savings.Display();
    }
}

