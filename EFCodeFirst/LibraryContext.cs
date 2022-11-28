using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    public class LibraryContext: DbContext
    {
        private string _connString;

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Novel> Novels { get; set; }

        public DbSet<Human> Human { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Personnel> Personnel { get; set; }

        public LibraryContext(string connString): base()
        {
            _connString = connString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(_connString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books);

            modelBuilder.Entity<Book>()
                .HasKey(b => b.Id);
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasMaxLength(200)
                .IsRequired();
            modelBuilder.Entity<Book>()
                .Property(b => b.PublishingYear)
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasMany(b => b.Novels)
                .WithMany(n => n.Books);

            /*
            modelBuilder.Entity<Reader>()
                .ToTable("Reader");
            */
        }
    }
}
