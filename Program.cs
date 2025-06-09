// See https://aka.ms/new-console-template for more information
// using System.Data.Common;
using libraryManagement;

// //Book book1 = new Book { Title = "Mahabarat", Author = "ABC" , ISBN = "ISBN000167"};
Book b2 = new Book { Title = "Mahabarat", Author = "ABC", ISBN = "ISBN000167", Id = "1444" };//("Raamayan", "EFG", "ISBN004368",  "003" );
b2.Display();
b2.Showinfo();
Magazine m1 = new Magazine("Peace", "111", 68);
m1.Showinfo();
