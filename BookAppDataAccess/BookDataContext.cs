using BookAppEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDataAccess
{
    public class BookDataContext: DbContext
    {



        public DbSet<Book> Books { get; set; }
    }
}
