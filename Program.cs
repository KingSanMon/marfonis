using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNIGI
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book01 = new Book("Кинг С.", "ОНО", "Роман", 4000, 1245);
            Book book02 = new Book("Солженицин А.", "Архипелаг ГУЛАГ", "роман", 3000, 1279);
            Book book03 = new Book("Сапковский А.", "Ведьмак", "фентези", 4100, 1340);

            Book[] books = new Book[3]; //количество

            books[0] = book01;
            books[1] = book02;
            books[2] = book03;


           // for (int i = 0; i < books.Length; i++)
           foreach (Book book in books)
           {

                Console.WriteLine("Автор: {0}\n", book.GetAuthor());
                Console.WriteLine("Книга: {0}\n", book.GetTitle());
                Console.WriteLine("Жанр: {0}\n", book.GetGenre());
                Console.WriteLine("Тираж: {0}\n", book.GetCirculation());
                Console.WriteLine("Страницы: {0}\n", book.GetNumber());
                Console.WriteLine("-------------------------------------------------");
                
            }
            Console.ReadKey();
        }
    }
}
