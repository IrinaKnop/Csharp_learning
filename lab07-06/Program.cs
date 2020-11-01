using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];
            books[0] = new Book();
            books[1] = new Book();
            books[2] = new Book();

            books[0].SetBook("Г.Н. Черкесов", "Надежность технических систем с временной избыточностью", 294, 1974);
            books[1].SetBook("Г.К. Жуков", "Воспоминвния и размышления", 736, 1969);
            books[2].SetBook("У. Гибсон", "Нейромант", 271, 1984);

            Array.Sort(books);

            foreach (Book book in books)
            {
                book.Show();
            }
        }
    }
}
