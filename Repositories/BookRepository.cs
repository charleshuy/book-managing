using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;
        //ta ko new som ngay o day
        //moi CRUD me thod thi ta new lai cai class DbContext

        public List<Book> GetBooks()
        {
            _context = new BookManagementDbContext();
            return _context.Books.ToList();
        }
        public void UpdateBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Update(book);
            _context.SaveChanges();//xuong data base run sql
        }
        public void AddBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        public void DeleteBook(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
