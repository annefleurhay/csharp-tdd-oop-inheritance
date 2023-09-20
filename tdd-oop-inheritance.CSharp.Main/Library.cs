using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {

        List<Item> items = new List<Item>();
        

        public void addToStock(Item item) {
            this.items.Add(item);
        }

        

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)
        public string checkInItem(string title) {
            //List<Article> filtered = this.articles.Where(article => article.title.Equals(title)).ToList();
            Item item = items.FirstOrDefault(i => i.title.Equals(title));
            
            if (item == null)
            {
                return "item is not part of the library's collection";
            }
            return item.checkIn();
            
        }

        public string checkOutItem(string title) {
            //List<Article> filtered = (List<Article>)this.articles.Where(article => article.title.Equals(title));
            //List<Article> filtered = this.articles.Where(article => article.title.Equals(title)).ToList();
            Item item = items.FirstOrDefault(i =>i.title.Equals(title));
            if (item == null)
            {
                return "item is not part of the library's collection";
            }
            return item.checkOut();
            
        }
    }
}
