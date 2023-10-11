using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{

    internal class Book
    {
        public string title;
        public string auther;
        public int pages;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //create a new book object,at this point book is now a data type in C# 
            
            //creation of first book, you can now create thousands of different books eg for a library app!
            book1.title = "Harry Potter";
            book1.auther = "JK Rowling";
            book1.pages = 400;


            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.auther = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);

        //freeze
        Console.ReadLine();
        }
    }
   
}
