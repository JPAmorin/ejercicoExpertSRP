using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibraryName { get ; }
        public string LibrarySector { get ; }
        public string LibraryShelve { get ; }

        public Book(String title, String author, String code, String LibraryName, String sector, String shelve)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            this.LibraryName = LibraryName;
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

        public void BookInLibrary(String LibraryName, String sector, String shelve)
        {
            Library Ignis = new Library("Ignis");
            Ignis.ShelveBook(sector, shelve);
        }
        public void BookAviso()
        {
            Console.WriteLine($"Libro {this.Title} de {this.Author} está en la librería {this.LibraryName} en el sector {this.LibrarySector} estantería {this.LibraryShelve}.");
        }

    }
    public class Library
    {
        public string LibraryName { get ; }
        public string LibrarySector { get ; set ;}
        public string LibraryShelve { get ; set ;}
        
        public Library(String LibraryName)
        {
            this.LibraryName = LibraryName;
        }
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = LibrarySector;
            this.LibraryShelve = LibraryShelve;

        }
    }
}
