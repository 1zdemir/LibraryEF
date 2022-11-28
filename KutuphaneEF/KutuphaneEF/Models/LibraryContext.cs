using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneEF.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLocation> BookLocations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Library> Libraries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=KutuphaneEF;Trusted_Connection=True;");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookLocation>().HasKey(b => new { b.ISBN, b.LibraryId });
        }
    }
}
