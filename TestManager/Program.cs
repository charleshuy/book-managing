using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Entities;
using System.Threading.Channels;

namespace TestManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            BookManagementDbContext context = new BookManagementDbContext();
            List<Book> arr = context.Books.ToList();
            arr.ForEach(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));
            //context.Books.ForEachAsync(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));
            //2. in ra tat cac sach thuoc 5
            arr.Where(x => x.BookCategoryId == 5).ToList().ForEach(x => Console.WriteLine(x.BookId + " | " + x.BookName + " | " + x.PublicationDate));

        }
    }
}
