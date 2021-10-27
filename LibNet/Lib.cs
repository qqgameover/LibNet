using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibNet
{
    class Lib
    {
        public List<Book> Books { get; private set; }
        public List<Person> Persons { get; private set; }

        public Lib(List<Book> books, List<Person> persons)
        {
            Books = books;
            Persons = persons;
        }

        public void ShowBookList()
        {
            foreach (var book in Books)
            {
                var rentStr = book.IsRented == false ? " og den er ikke leid ut" : " og den er leid ut";
                Console.WriteLine(book.BookName + rentStr);
            }
        }

        public void HandleCommands()
        {
            var command = Console.ReadLine();
            var splitCommand = command.Split(" ", 3);
            if(command == "vis" && splitCommand.Length == 1) ShowBookList();
            if (splitCommand[0] == "vis" && splitCommand.Length == 2)
            {
                foreach (var p in Persons)
                {
                    if(p.Name != splitCommand[1]) continue;
                    p.GetRentingList();
                }
            }
            if (splitCommand[0].Contains("leie"))
            {
                foreach (var p in Persons)
                {
                    if (p.Name == splitCommand[1])
                    {
                        foreach (var b in Books)
                        {
                            if (b.BookName == splitCommand[2])
                            {
                                RentBook(b, p);
                            }
                        }
                    }
                }
            }
        }
        public void RentBook(Book b, Person p)
        {
            p.RentingList.Add(b);
            b.SetRenter(p);
        }
    }
}
