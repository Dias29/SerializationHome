using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeHome
{
    [Serializable]
    [Atribute("Books")]
    public class Book
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Author { get; set; }
        public DateTime YearOfWrote { get; set; }

        public Book(string name, int cost, string author, DateTime year)
        {
            Name = name;
            Cost = cost;
            Author = author;
            YearOfWrote = year;
        }

    }
}
