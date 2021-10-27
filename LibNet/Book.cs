using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNet
{
    class Book
    {
        public string BookName { get; private set; }
        public Person Renter { get; private set; }
        public bool IsRented => Renter != null;

        public Book(string bookName)
        {
            BookName = bookName;
        }

        public void SetRenter(Person p)
        {
            Renter = p;
        }
    }
}
