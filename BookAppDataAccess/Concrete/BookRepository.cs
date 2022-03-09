using BookAppDataAccess.Abstract;
using BookAppEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDataAccess.Concrete
{
    public class BookRepository : IBookRepository
    {
        public Book Delete(int id)
        {
           using (BookDataContext db = new BookDataContext())
            {
               
            }
        }

        public List<Book> GetAllList()
        {
            throw new NotImplementedException();
        }

        public Book GetByID(int id)
        {
           using (BookDataContext db = new BookDataContext())
            {
                return db.Books.FirstOrDefault(x=>x.ID == id);
            }
        }

        public Book Insert(Book book)
        {
            using (BookDataContext db = new BookDataContext())
            {
               db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public Book Update(Book book)
        {
            using (BookDataContext db = new BookDataContext())
            {
               var update = db.Books.Update(book);
                db.SaveChanges();
            }
        }

        void IBookRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
