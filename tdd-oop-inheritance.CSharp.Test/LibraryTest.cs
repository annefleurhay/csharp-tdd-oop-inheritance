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
            Book book = new Book("Junit Rocks");
            library.addToStock(book);

            string result = library.checkInItem("Junit Rocks");

            Assert.IsTrue(result == "item is not currently on loan");
        }


        [Test]
        public void Test2()
        {
            Library library = new Library();
            Book book = new Book("Junit Rocks");
            library.addToStock(book);

            string result = library.checkOutItem("Junit Rocks");

            Assert.AreEqual("item has been checked out", result); 
        }

        [Test]
        public void Test3()
        {
            Library library = new Library();
            Article article = new Article("Introduction to C#");

            string result = library.checkInItem("Introduction to C#");

            Assert.AreEqual("item is not part of the library's collection", result);
        }
    }
}
