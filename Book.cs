namespace libraryManagement;

public class Book : LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; } 
    public string ISBN { get; set; } 
    public string ID { get; set; } //International Standard Book Number
    public Book(string title, string author, string isbn, string id) : base(title, id)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        ID = Id;
    }

    public Book(string title, string author, string id) : base(title, id)
    {
        Title = title;
        Author = author;
        ID = Id;
    }
    public Book(){}
    public void Display()
    {
        Console.WriteLine($"Title of the Book : {Title}");
        Console.WriteLine($"Author is : {Author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }
}

