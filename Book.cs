using System;
class Book{
    static string BookName ="Stark";
    string Title;
    string Author;
    readonly int ISBN;
    public Book( string Title, string Author, int ISBN){
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }
    public void  DisplayBookName(){
        Console.WriteLine(BookName);
            }
    public void Display() {
        if (this is Book){
            Console.WriteLine("Book Name: "+BookName);
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("ISBN: "+ISBN);
        }
        else{
            Console.WriteLine("This is not a Book instance.");
        }
    }  
    public static void Main(string[] args){
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 123456);
        book1.Display();
        Book book2 = new Book("The Da Vinci Code", "Dan Brown", 654321);
        book2.Display();
        book1.DisplayBookName();
    }    
}