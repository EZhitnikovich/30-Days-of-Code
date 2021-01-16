using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected string title;
    protected string author;

    public Book(string t, string a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

class MyBook: Book
{
    public int Price { get; set; }
    public MyBook(string title, string author, int price): base(title, author)
    {
        Price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}\n" +
                          $"Author: {author}\n" +
                          $"Price: {Price}");
    }
}

class Solution
{
    static void Main(string[] args)
    {
        string title = Console.ReadLine();
        string author = Console.ReadLine();
        int price = Int32.Parse(Console.ReadLine());
        Book new_novel = new MyBook(title, author, price);
        new_novel.display();
    }
}