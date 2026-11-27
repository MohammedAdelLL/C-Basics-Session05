using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics_Session05
{

    enum Genre 
    { Fiction,
        NonFiction,
        Science
    }
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public Genre gen;

    }
}
