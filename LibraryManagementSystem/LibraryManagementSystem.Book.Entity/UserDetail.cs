using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Book.Entity
{
    public class UserDetail
    {
       // UserDetail userDetail = new UserDetail();
        public Name IssuerName { get; set; }

        public List<BookDetails> Book { get; set; }

        public UserDetail()
        {
            Book = new List<BookDetails>();
            IssuerName = new Name();
        }

        public override string ToString()
        {
            return IssuerName.FirstName + IssuerName.LastName + IssuerName.UserId;
        }
    }
}
