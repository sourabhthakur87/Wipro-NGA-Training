﻿using System;

class Book
{
    // Define properties
    // Complete Step 1:............
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Define constructor
    // Complete Step 2:............

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;

    }

    public void DisplayBook()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Book Author: " + Author);
        Console.WriteLine("Book Year: " + Year);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter book details
        Console.WriteLine("Enter book's title:");
        // Complete Step 3:............
        string title = Console.ReadLine();

        Console.WriteLine("Enter book's author:");
        // Complete Step 4:............
        string author = Console.ReadLine();

        Console.WriteLine("Enter book's year:");
        // Complete Step 5:............
        int year = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the Book class
        // Complete Step 6:............
        Book myBook = new Book(title, author, year);

        // Print book details
        // Complete Step 7:............
        myBook.DisplayBook();


    }
}
