using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.EFCore.Models.ManyToMany;
using Assignment1.EFCore.Models.OneToMany;
using Assignment1.EFCore.Models.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.EFCore.Models
{
    public class Assignment1Context : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book_Author> Book_Authors { get; set; }

        public Assignment1Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HN-PC87;Initial Catalog=Assignment1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Book_Author>().HasOne(x => x.Book).WithMany(a => a.Book_Authors).HasForeignKey(b => b.BookId);

            modelBuilder.Entity<Book_Author>().HasOne(x => x.Author).WithMany(a => a.Book_Authors).HasForeignKey(b => b.AuthorId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
