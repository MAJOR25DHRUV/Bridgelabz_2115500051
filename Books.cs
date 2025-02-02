
using System;

class books
{
    public string ISBN { get; set; }
    protected string Title { get; set; }
    private string Author;

    public books(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void SetAuthor(string author)
    {
        Author = author;
    }

    public string GetAuthor()
    {
        return Author;
    }
}

class Ebooks : books
{
    public Ebooks(string isbn, string title, string author) : base(isbn, title, author) { }

    public void Display()
    {
        Console.WriteLine($"Ebooks: ISBN: {ISBN}, Title: {Title}");
    }
}

class Program
{
    static void Main()
    {
        books books = new books("12345", "C# Basics", "John Doe");
        books.SetAuthor("Jane Doe");
        Console.WriteLine($"Author: {books.GetAuthor()}");

        Ebooks ebooks = new Ebooks("54321", "C# Advanced", "Mark Smith");
        ebooks.Display();
    }
}

