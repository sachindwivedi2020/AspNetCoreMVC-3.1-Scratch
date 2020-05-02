using BookStore.DBLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.DBLayer
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> dbContextOptions)
           : base(dbContextOptions)
        {

        }
        public DbSet<Book> Books { get; set; }


        // We can configure db connectionstring By overriding OnConfiguring() method in our dbcontext class.
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=BookStore;IntegratedSecurity=True");
        //        base.OnConfiguring(optionsBuilder);
        //    }
        //}


    }
}
