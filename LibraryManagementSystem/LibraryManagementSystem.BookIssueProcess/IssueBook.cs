using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Book.Entity;

namespace LibraryManagementSystem.BookIssueProcess
{
    public class IssueBook
    {
        public List<BookDetails> BookDetails = new List<BookDetails>();

        public List<BookDetails> AddBookDetails()
        {
            BookDetails details = new BookDetails("Vision 2020", " APJ Abdul kalam", Genre.inspirational, 454);
            //details.Author = " APJ Abdul kalam";
            //details.BookId = 454;
            //details.Genre = Genre.inspirational;
            //details.BookName = "Vision 2020";
            

            BookDetails.Add(details);

            BookDetails details1 = new BookDetails("Space and world", "Stephen Hawkings", Genre.technical, 455);
            ////details.Author = "Stephen Hawkings";
            ////details.BookId = 455;
            ////details.Genre = Genre.technical;
            ////details.BookName = "Space And World";
            
            BookDetails.Add(details1);
            return BookDetails;

        }

        public string GetBookDetails()
        {
            string result = string.Empty;
            foreach(var a in BookDetails)
            {
                result += a.ToString();
            }

            return result;
           // return BookDetails.ToString();
        }
    }
}
