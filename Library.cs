// Program.cs
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("The Great Gatsby", "B001", "F. Scott Fitzgerald"),
            new Magazine("National Geographic", "M001", "Various"),
            new DVD("Inception", "D001", "Christopher Nolan")
        };

        foreach (LibraryItem item in items)
        {
            Console.WriteLine("Item Details:");
            item.GetItemDetails();
            Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");
            
            // Using 'as' operator for interface checking
            IReservable reservable = item as IReservable;
            if (reservable != null)
            {
                Console.WriteLine("Availability: " + reservable.CheckAvailability());
            }
            Console.WriteLine();
        }
    }
}

// Abstract base class for all library items
public abstract class LibraryItem
{
    // Private fields for encapsulation
    private string itemId;
    private string title;
    private string author;
    private bool isLoaned;

    // Constructor to initialize item details
    protected LibraryItem(string title, string itemId, string author)
    {
        this.Title = title;
        this.ItemId = itemId;
        this.Author = author;
        this.isLoaned = false;
    }

    // Public properties with validation
    public string Title
    {
        get { return title; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Title cannot be empty");
            title = value;
        }
    }

    public string ItemId
    {
        get { return itemId; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Item ID cannot be empty");
            itemId = value;
        }
    }

    public string Author
    {
        get { return author; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Author cannot be empty");
            author = value;
        }
    }

    // Abstract method for loan duration
    public abstract int GetLoanDuration();

    // Concrete method for displaying item details
    public virtual void GetItemDetails()
    {
        Console.WriteLine("ID: " + ItemId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }

    // Protected method to check loan status
    protected bool IsLoaned()
    {
        return isLoaned;
    }

    // Protected method to set loan status
    protected void SetLoanStatus(bool status)
    {
        isLoaned = status;
    }
}

// Interface for reservable items
public interface IReservable
{
    bool ReserveItem();
    string CheckAvailability();
}

// Book implementation
public class Book : LibraryItem, IReservable
{
    // Constructor
    public Book(string title, string itemId, string author)
        : base(title, itemId, author) { }

    // Implementation of abstract method
    public override int GetLoanDuration()
    {
        return 21; // 3 weeks for books
    }

    // Implementation of interface methods
    public bool ReserveItem()
    {
        if (!IsLoaned())
        {
            SetLoanStatus(true);
            return true;
        }
        return false;
    }

    public string CheckAvailability()
    {
        return IsLoaned() ? "Currently on loan" : "Available";
    }
}

// Magazine implementation
public class Magazine : LibraryItem, IReservable
{
    // Constructor
    public Magazine(string title, string itemId, string author)
        : base(title, itemId, author) { }

    // Implementation of abstract method
    public override int GetLoanDuration()
    {
        return 7; // 1 week for magazines
    }

    // Implementation of interface methods
    public bool ReserveItem()
    {
        if (!IsLoaned())
        {
            SetLoanStatus(true);
            return true;
        }
        return false;
    }

    public string CheckAvailability()
    {
        return IsLoaned() ? "Currently on loan" : "Available";
    }
}

// DVD implementation
public class DVD : LibraryItem, IReservable
{
    // Constructor
    public DVD(string title, string itemId, string author)
        : base(title, itemId, author) { }

    // Implementation of abstract method
    public override int GetLoanDuration()
    {
        return 14; // 2 weeks for DVDs
    }

    // Implementation of interface methods
    public bool ReserveItem()
    {
        if (!IsLoaned())
        {
            SetLoanStatus(true);
            return true;
        }
        return false;
    }

    public string CheckAvailability()
    {
        return IsLoaned() ? "Currently on loan" : "Available";
    }
}