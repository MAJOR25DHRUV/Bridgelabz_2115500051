using System;

class LibraryBook
{
    private string title;
    private string author;
    private double price;
    private bool isAvailable;

    // Default Constructor
    public LibraryBook()
    {
        this.title = "Unknown";
        this.author = "Unknown";
        this.price = 0.0;
        this.isAvailable = true;
    }

    // Parameterized Constructor
    public LibraryBook(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.isAvailable = true;
    }

    // Method to Borrow a Book
    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"The book '{title}' has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Sorry, the book '{title}' is already borrowed.");
        }
    }

    // Method to Return a Book
    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"The book '{title}' has been returned.");
    }

    // Display Book Details
    public void DisplayBook()
    {
        string availability = isAvailable ? "Available" : "Not Available";
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}, Availability: {availability}");
    }
}

// Example Usage
class Program
{
    static void Main()
    {
        LibraryBook book1 = new LibraryBook("The Alchemist", "Paulo Coelho", 299.99);
        book1.DisplayBook();
        book1.BorrowBook();
        book1.DisplayBook();
        book1.ReturnBook();
        book1.DisplayBook();
    }
}
