using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        private BookCategoryRepository _repo = new();
        //CUNG CAP DATA CHO CAI FORM, THUC RA LA CUNG CAP DATA CHO CAI COMBOX/DROP DOWN
        //LE RA PHAI LAY TAT CA CATECORY TU DATA BASE NHUNG TAM THOI HARD CODE
        public List<BookCategory> GetAllCategories()
        {          
            return _repo.GetBookCategories();
        }
    }
}
