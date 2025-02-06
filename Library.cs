using System;
using System.Collections.Generic;

public class Book
{
    private string title;
    private string author;
    private string isbn;

    // Property for Title with validation
    public string Title 
    { 
        get 
        { 
            return title; 
        } 
        private set 
        { 
            if (value == null) 
            {
                throw new ArgumentNullException("value");
            }
            title = value;
        }
    }

    // Property for Author with validation
    public string Author 
    { 
        get 
        { 
            return author; 
        } 
        private set 
        { 
            if (value == null) 
            {
                throw new ArgumentNullException("value");
            }
            author = value;
        }
    }

    // Property for ISBN with validation
    public string ISBN 
    { 
        get 
        { 
            return isbn; 
        } 
        private set 
        { 
            if (value == null) 
            {
                throw new ArgumentNullException("value");
            }
            isbn = value;
        }
    }

    // Constructor for Book class
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    // Overriding ToString method to return book details
    public override string ToString()
    {
        return Title + " by " + Author + " (ISBN: " + ISBN + ")";
    }
}

public class Library
{
    private string name;
    private readonly List<Book> books;

    // Property for Library Name with validation
    public string Name 
    { 
        get 
        { 
            return name; 
        } 
        private set 
        { 
            if (value == null) 
            {
                throw new ArgumentNullException("value");
            }
            name = value;
        }
    }

    // Property to get books as a read-only list
    public IReadOnlyList<Book> Books 
    { 
        get 
        { 
            return books.AsReadOnly(); 
        } 
    }

    // Constructor for Library class
    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    // Method to add a book to the library
    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException("book");
        }
        
        books.Add(book);
    }

    // Method to remove a book from the library
    public bool RemoveBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException("book");
        }
        
        return books.Remove(book);
    }

    // Method to find books by a given author
    public List<Book> FindBooksByAuthor(string author)
    {
        // Creating a list to store matching books
        List<Book> matchingBooks = new List<Book>();

        // Looping through each book in the library
        foreach (Book book in books)
        {
            // Checking if the author's name matches (case insensitive)
            if (string.Equals(book.Author, author, StringComparison.OrdinalIgnoreCase))
            {
                matchingBooks.Add(book);
            }
        }

        return matchingBooks;
    }
}

public class Program
{
    public static void Main()
    {
        // Creating books
        Book book1 = new Book("C# Basics", "John Doe", "12345");
        Book book2 = new Book("Advanced C#", "John Doe", "67890");
        Book book3 = new Book("Python Fundamentals", "Jane Smith", "11223");

        // Creating a library
        Library myLibrary = new Library("City Library");

        // Adding books to the library
        myLibrary.AddBook(book1);
        myLibrary.AddBook(book2);
        myLibrary.AddBook(book3);

        // Displaying all books in the library
        Console.WriteLine("All Books in the Library:");
        foreach (Book book in myLibrary.Books)
        {
            Console.WriteLine(book.ToString());
        }

        Console.WriteLine();

        // Searching for books by author
        Console.WriteLine("Books by John Doe:");
        List<Book> booksByJohnDoe = myLibrary.FindBooksByAuthor("John Doe");
        foreach (Book book in booksByJohnDoe)
        {
            Console.WriteLine(book.ToString());
        }

        Console.WriteLine();

        // Removing a book and displaying the updated list
        myLibrary.RemoveBook(book2);
        Console.WriteLine("After removing 'Advanced C#':");
        foreach (Book book in myLibrary.Books)
        {
            Console.WriteLine(book.ToString());
        }
    }
}
