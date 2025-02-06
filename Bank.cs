using System;
using System.Collections.Generic;

// Represents a bank that manages customers and their accounts
class Bank
{
    private string bankName; // Private field for bank name
    private List<Customer> customers; // Private list to store customers

    // Constructor to initialize bank with a name
    public Bank(string name)
    {
        bankName = name;
        customers = new List<Customer>();
    }

    // Method to get the bank's name
    public string GetBankName()
    {
        return bankName;
    }

    // Method to open an account for a customer with an initial deposit
    public Account OpenAccount(string customerName, double initialDeposit)
    {
        // Check if customer already exists
        Customer customer = GetCustomerByName(customerName);
        if (customer == null)
        {
            // Create a new customer if not found
            customer = new Customer(customerName);
            customers.Add(customer);
        }

        // Create a new account and associate it with the customer
        Account newAccount = new Account(this, customer, initialDeposit);
        customer.AddAccount(newAccount);
        return newAccount;
    }

    // Method to find a customer by their name
    public Customer GetCustomerByName(string name)
    {
        foreach (Customer customer in customers)
        {
            if (customer.GetCustomerName() == name)
            {
                return customer;
            }
        }
        return null; // Return null if customer is not found
    }
}

// Represents a bank customer who can have multiple accounts
class Customer
{
    private string customerName; // Private field to store customer name
    private List<Account> accounts; // Private list to store customer accounts

    // Constructor to initialize customer with a name
    public Customer(string name)
    {
        customerName = name;
        accounts = new List<Account>();
    }

    // Method to get the customer's name
    public string GetCustomerName()
    {
        return customerName;
    }

    // Method to add an account to the customer's account list
    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    // Method to display the balance of all accounts owned by the customer
    public void ViewBalance()
    {
        Console.WriteLine("Customer: " + customerName);
        foreach (Account account in accounts)
        {
            Console.WriteLine("Account Number: " + account.GetAccountNumber() + ", Balance: " + account.GetBalance());
        }
    }
}

// Represents a bank account associated with a customer
class Account
{
    private static int accountCounter = 1000; 
    private int accountNumber; 
    private double balance; 
    private Bank bank; 
    private Customer customer; 

    // Constructor to initialize an account with bank, customer, and initial deposit
    public Account(Bank bank, Customer customer, double initialDeposit)
    {
        this.bank = bank;
        this.customer = customer;
        balance = initialDeposit;
        accountNumber = accountCounter; 
        accountCounter++; 
    }

    // Method to get the account number
    public int GetAccountNumber()
    {
        return accountNumber;
    }

    // Method to get the current account balance
    public double GetBalance()
    {
        return balance;
    }

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine("Deposited " + amount + " into Account " + accountNumber + ". New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrew " + amount + " from Account " + accountNumber + ". New Balance: " + balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }
}

class Program
{
    public static void Main()
    {
        // Creating a bank object
        Bank bank = new Bank("XYZ Bank");

        // Opening accounts for customers with initial deposits
        Account account1 = bank.OpenAccount("John Doe", 1000);
        Account account2 = bank.OpenAccount("Jane Doe", 2000);
        Account account3 = bank.OpenAccount("John Doe", 500);

        // Performing transactions
        account1.Deposit(500); 
        account2.Withdraw(1000); 
        account3.Deposit(200); 

        // Retrieving John Doe's customer object and displaying his balance
        Customer john = bank.GetCustomerByName("John Doe");
        if (john != null)
        {
            john.ViewBalance();
        }

        // Retrieving Jane Doe's customer object and displaying her balance
        Customer jane = bank.GetCustomerByName("Jane Doe");
        if (jane != null)
        {
            jane.ViewBalance();
        }
    }
}
