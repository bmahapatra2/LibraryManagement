﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem.BookIssueProcess;
using LibraryManagementSystem.IssuedBookData;
using ExcludedConsole;

namespace LibraryManagementSystem.CheckFunctioning
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_For_Added_Issued_Books()
        {
            IssueBook issueBook = new IssueBook();
           int count= issueBook.AddBookDetails().Count;
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void Check_For_Issued_Book()
        {
            IssueBook issuedbook = new IssueBook();
            LibraryIssuedBooks books = new LibraryIssuedBooks();
            string[] data=books.BookIssued(issuedbook);
            Assert.AreSame("Vision 2020", data[0]);
        }
}
}
