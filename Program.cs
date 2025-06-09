
using libraryManagement;

// //Book book1 = new Book { Title = "Mahabarat", Author = "ABC" , ISBN = "ISBN000167"};
Book b2 = new Book { Title = "Mahabarat", Author = "ABC", ISBN = "ISBN000167", Id = "1444" };//("Raamayan", "EFG", "ISBN004368",  "003" );
b2.Showinfo();
Magazine m1 = new Magazine("Peace", "111", 68);
m1.Showinfo();
DVD d1 = new DVD("Silent", "TS", 143);
d1.Showinfo();

Console.WriteLine("------------Pay Due Amount for extra days----------");
Console.WriteLine("Number of days : ");
int days = int.Parse(Console.ReadLine());
var due = 15;
var fine = 0;
if (days > due)
{
    var diff = days - due;
    for (int i = 1; i <= diff; i++)
    {
        fine += 2;
    }
}
Console.WriteLine($"The Fine amount you have to pay  : {fine}");
Console.ReadKey();
Console.WriteLine("Press any key to exit..");