using System;

class Book {
    private string title;
    private string author;
    private int price;

    // Constructor
    public Book(string title, string author, int price) {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Getter Methods (since auto-properties are not supported in older C#)
    public string GetTitle() {
        return title;
    }

    public string GetAuthor() {
        return author;
    }

    public int GetPrice() {
        return price;
    }

    public void DisplayBook() {
        Console.WriteLine(string.Format("Book Title: {0}", title));
        Console.WriteLine(string.Format("Book Author: {0}", author));
        Console.WriteLine(string.Format("Book Price: {0}", price));
    }
}

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();
        
        Console.Write("Enter Book Author: ");
        string author = Console.ReadLine();
        
        Console.Write("Enter Book Price: ");
        int price = Convert.ToInt32(Console.ReadLine());

        Book obj = new Book(title, author, price);
        obj.DisplayBook();
    }
}
