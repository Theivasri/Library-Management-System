namespace libraryManagement;
public class LibraryItem
{
    public string Id;
    public string Title;

    public LibraryItem(string title)
    {
        Title = title;
    }
    public LibraryItem(){}

    public void Showinfo()
    {
        Console.WriteLine($"Book ID is : {Id}");
        Console.WriteLine($"Ttitle of book is : {Title}");
    }
}