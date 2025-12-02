using System;
using System.Collections.Generic;
using System.Text;
namespace Project
{
    internal class BookManager
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            var Result = books.FirstOrDefault(b => b.Title == book.Title);
            if (Result != null)
            {
                books.Remove(Result);
            }
        }
        public Book? SearchBook(string title)
        {
            return books.FirstOrDefault(b => b.Title == title);
        }
        public void ShowAll()
        {
            foreach (var book in books)
            {
                Console.WriteLine
                ($"Title: {book.Title} Author: {book.Author} ReleaseYear: {book.ReleaseYear}");
            }
        }
    }
}