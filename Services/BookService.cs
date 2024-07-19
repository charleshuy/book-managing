using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-LAYER Architecture:
    //[1]            [2]               [3]                SQLSERVER
    //UI-Form ---- Services ---- Repositories ---------------  DB
    //MainUI ---- BookService--- BookRepository (Book entity)   table
    //request/respond         <--->
    //dua data xuong DB            choi truc tiep vs DB: len, xuong
    //lay data tu DB show                               CRUD table
    //      RAM                             DB dia cung SSD/HDD
    public class BookService
    {
        private BookRepository repo = new();
        public List<Book> GetAllBooks()
        {
            return repo.GetBooks();
        }
        public void AddBookFromUI(Book book)
        {
            repo.AddBook(book);
        }
        public void RemoveBookFromUI(Book book)
        {
            repo.DeleteBook(book);
        }
        public void UpgradeBookfromUI(Book book) 
        {
            repo.UpdateBook(book);
        }
    }
}
