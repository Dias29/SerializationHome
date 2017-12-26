using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SerializeHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "book.bin";

            List<Book> book = new List<Book>
            {
                new Book(" C# 5.0 and the .NET 4.5 Framework", 5000, "Andrew Troelsen", new DateTime(2013) ),
                new Book(" Изучаем с#. Полное Руководство", 6000, "Герберт Шилдт", new DateTime(2010) ),
                new Book(" Программирование на С++", 7000, "Бьерн Страуструп", new DateTime(2011) ),
                new Book(" Язык программирования С++", 4000, "Стивен Прата", new DateTime(2009) )
            };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(file, FileMode.Create))
            {
                formatter.Serialize(stream, book.ToArray());
            }

            List<Book> books;

            using (FileStream stream = new FileStream(file, FileMode.OpenOrCreate))
            {
                books = new List<Book>(formatter.Deserialize(stream) as Book[]);
            }



        }
    }
}
