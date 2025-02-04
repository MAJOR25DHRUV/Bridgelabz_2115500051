using System;
class BankAccount{
    static string bankName ="Stark";
    string AccountHolderName;
    readonly int AccountNumber;
    public static int TotalAccounts=0;
    public BankAccount(string AccountHolderName, int AccountNumber){
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        TotalAccounts++;
    }
    static void GetTotalAccounts(){
        Console.WriteLine(TotalAccounts);
    }
    public void DisplayAccountDetails(){
        if(this is BankAccount){
            Console.WriteLine("Bank Name: "+bankName);    

            
            Console.WriteLine("Account Holder Name: "+AccountHolderName);
            Console.WriteLine("Account Number: "+AccountNumber);
        }
        else{
            Console.WriteLine("This is not a BankAccount instance.");
        }

    }
    public static void Main(string[] args){
        BankAccount account1 = new BankAccount("tony", 123456);
        account1.DisplayAccountDetails();
        BankAccount account2 = new BankAccount("pepper", 654321);
        account2.DisplayAccountDetails();
        BankAccount.GetTotalAccounts();
    }
    
}