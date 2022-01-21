using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNIGI
{
    class Book
    {
        private string author;
        private string title;
        private string genre;
        private int circulation;
        private int Number;

        public Book(string author, string title, string genre, int circulation, int Number)
        {
            this.author = author;
            this.title = title;
            this.genre = genre;
            this.circulation = circulation;
            this.Number = Number;
        }

        public string GetAuthor()
        {
            return this.author;
        }
        public string GetTitle()
        {
            return this.title;
        }
        public string GetGenre()
        {
            return this.genre;
        }
        public int GetCirculation()
        {
            return this.circulation;
        }
        public int GetNumber()
        {
            return this.Number;
        }
    }
}
