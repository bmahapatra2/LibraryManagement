using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Book.Entity
{
    public class BookDetails
    {
        private string _bookname;
        private string _author;
        private Genre _genre;
        private int _bookid;

        public string BookName { get; set; }

        public string Author { get; set; }
        
        public Genre Genre { get; set; }

        public int BookId { get; set; }

        public BookDetails(string BookName, string Author, Genre Genre, int BookId)
        {
            _bookname = BookName;
            _author = Author;
            _genre = Genre;
            _bookid = BookId;
        }

        public BookDetails()
        {
        }

        public override string ToString()
        {
            
            return _bookname+','+_author+','+_genre+','+_bookid+"\n";
        }


    }
}
