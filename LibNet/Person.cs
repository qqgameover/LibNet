using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibNet
{
    class Person
    {
        public string Name { get; private set; }
        public List<Book> RentingList { get; private set; }

        public Person(string name)
        {
            Name = name;
            RentingList = new List<Book>();
        }

        public void GetRentingList()
        {
            Console.WriteLine("Leide bøker:");
            foreach (var book in RentingList)
            {
                Console.WriteLine(book.BookName);
            }
        }
    }
}
