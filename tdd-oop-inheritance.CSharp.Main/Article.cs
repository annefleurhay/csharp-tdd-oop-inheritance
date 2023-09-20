using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Article : Item {

        public Article(string title) : base(title) 
        { }
        public override string checkIn()
        {
            if (isOnLoan())
            {
                onLoan = false;
                return "item has been checked in";
            }
            return "item is not currently on loan";
        }

        public override string checkOut()
        {
            if (!isOnLoan())
            {
                onLoan = true;
                return "item has been checked out";
            }
            return "item is currently on loan";
        }
    }



}
