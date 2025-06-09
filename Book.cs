namespace libraryManagement;

public class Book : LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; } 
    public string ISBN { get; set; }  //International Standard Book Number
    public Book(string title, string author, string isbn) : base(title)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public Book(string title, string author) : base(title)
    {
        Title = title;
        Author = author;
    }
    public Book(){}
    public void Display()
    {
        Console.WriteLine($"Title of the Book : {Title}");
        Console.WriteLine($"Author is : {Author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }
}

