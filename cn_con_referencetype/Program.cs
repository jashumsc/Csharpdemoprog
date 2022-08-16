using System;

struct Books
{
    public string title;
    public string author;

};

public class Book
{
    public static void Main(string[] args)
    {
        Books Book1;
        Book1.title = "C Programming";
        Book1.author = "Nuha Ali";

        Console.WriteLine(Book1.author + "  is the author" + " of " + Book1.title);
        Books obj = Book1;
        Console.WriteLine(obj.title);
    }
}
