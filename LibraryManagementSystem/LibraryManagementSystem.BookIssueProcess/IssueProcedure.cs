using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Book.Entity;

namespace LibraryManagementSystem.BookIssueProcess
{
    public class IssueProcedure
    {
        List<UserDetail> BookIssuerDetail = new List<UserDetail>();
        public List<UserDetail> IssueBook (BookDetails book)
        {
            UserDetail user = new UserDetail();

            user.IssuerName.FirstName = "Bandana ";
            user.IssuerName.LastName = "Mahapatra";
            user.IssuerName.UserId = 854;

            IssueBook bookdata = new IssueBook();
            bookdata.GetBookDetails();

            user.Book.AddRange(bookdata.BookDetails);
            BookIssuerDetail.Add(user);
            return BookIssuerDetail;
        }
    }
}
