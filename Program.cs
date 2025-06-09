// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using libraryManagement;

// //Book book1 = new Book { Title = "Mahabarat", Author = "ABC" , ISBN = "ISBN000167"};
Book b2 = new Book { Title = "Raamayan", Author = "EFG", ISBN = "ISBN004368", Id = "003" };
Book b1 = new Book ("Bagavat geeta", "XYZ", "43");

b1.Display();

b1.Showinfo();