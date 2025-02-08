using System;

// Base class representing a general Book
class Book
{
    public string Title { get; set; }  // Stores the title of the book
    public int PublicationYear { get; set; }  // Stores the publication year of the book

    // Method to display book details
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}, Published Year: {PublicationYear}");
    }
}

// Author class inherits from Book
class Author : Book
{
    public string Name { get; set; }  // Stores the author's name
    public string Bio { get; set; }  // Stores a short biography of the author

    // Overriding DisplayInfo() to include author details
    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {Title}, Published: {PublicationYear}, Author: {Name}, Bio: {Bio}");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating an instance of Author, which includes book details
        Author author = new Author
        {
            Title = "C# Fundamentals",
       
