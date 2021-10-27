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
        public bool IsRented { get; private set; }

        public Book(string bookName)
        {
            BookName = bookName;
            IsRented = false;
        }

        public void SetRenter(Person p)
        {
            Renter = p;
            IsRented = true;
        }
    }
}
