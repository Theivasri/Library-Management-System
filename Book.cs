namespace libraryManagement;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }  //International Standard Book Number

    public Book (string title, string author)
    {
        Title = title;
        Author = author;
    }
    public void Display()
    {
        Console.WriteLine($"Title of the Book : {Title}");
        Console.WriteLine($"Author is : {Author}");
        Console.WriteLine($"ISBN : {ISBN}");
    }
}
