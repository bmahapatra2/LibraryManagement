using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Book.Entity;
using LibraryManagementSystem.BookIssueProcess;


namespace LibraryManagementSystem.IssuedBookData
{
    public class LibraryIssuedBooks
    {
        public string[] BookIssued(IssueBook book)
        {
            IssueBook books = new IssueBook();
            books.AddBookDetails();
            string[] bookdata= books.GetBookDetails().Split(',');
            return bookdata;
        }
    }
}
