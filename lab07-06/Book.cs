using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab07_06
{
    class Book : IComparable
    {
        private String author;
        private String title;
        private int pages;
        private int year;

        public void SetBook(String author, String title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
        }



        public int GetYear()
        {
            return this.year;
        }

        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
    }
}
