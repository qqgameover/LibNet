using System;
using System.Collections.Generic;

namespace LibNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new Lib(new List<Book>
           {
               new ("The hunger games"),
               new ("They are watching"),
               new ("As above, so below")
           }, new List<Person>
           {
               new ("Kasper"),
               new ("Joakim"),
               new ("Terje")
           });
            while (true)
            {
                lib.HandleCommands();
            }
        }
    }
}
