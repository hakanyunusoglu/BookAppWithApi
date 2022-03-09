using BookAppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDataAccess.Abstract
{
    public interface IBookRepository
    {
        public List<Book> GetAllList();
        public Book GetByID(int id);
        void Insert(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}
