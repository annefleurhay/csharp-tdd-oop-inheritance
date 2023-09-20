using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_oop_inheritance.CSharp.Main;

namespace tdd_oop_inheritance.CSharp.Test
{
    public class LibraryTest
    {

        [Test]
        public void Test1()
        {
            Library library = new Library();
            Author author = new Author("John Doe", "john@example.com", "https://www.johndoe.com");
            Book book = new Book("Junit Rocks", author);
            library.addToStock(book);

            string result = library.checkInItem("Junit Rocks");

            Assert.IsTrue(result == "item is not currently on loan");
            Assert.AreEqual(author, book.Author);
        }


        [Test]
        public void Test2()
        {
            Library library = new Library();
            Author author = new Author("Carrie Slee", "carrieslee@gmail.com", "https://www.cs.nl");
            Book book = new Book("Junit Rocks", author);
            library.addToStock(book);

            string result = library.checkOutItem("Junit Rocks");

            Assert.AreEqual("item has been checked out", result);
            Assert.AreEqual(author, book.Author);

        }

        [Test]
        public void Test3()
        {
            Library library = new Library();
            Author author = new Author("Carrie Slee", "carrieslee@gmail.com", "https://www.cs.nl");
            Article article = new Article("Introduction to C#", author);

            library.addToStock(article); 

            string result = library.checkInItem("Introduction to C#");

            Assert.AreEqual("item is not currently on loan", result);
            Assert.AreEqual("Carrie Slee", article.Author.Name); 
            Assert.AreEqual("carrieslee@gmail.com", article.Author.ContactInformation);
            Assert.AreEqual("https://www.cs.nl", article.Author.Website);
        }
    }
}
