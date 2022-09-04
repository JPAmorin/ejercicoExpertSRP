using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Library Ignis = new Library("Ignis");
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034","Ignis","A","7");
            Book book2 = new Book("Pro C#","Troelsen","001-035","Ignis","B","3");
            book1.BookInLibrary("Ignis","A","7");
            book2.BookInLibrary("Ignis","B","3");
            book1.BookAviso();
            book2.BookAviso();
        }
    }
}