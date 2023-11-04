using System;
using Microsoft.EntityFrameworkCore;

namespace BookshelfAPI.Models
{
	public class DataContext : DbContext
	{

        public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

        public DataContext() : base()
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(p => p.authorId)
                .IsRequired()
                .HasMaxLength(12);

            modelBuilder.Entity<Book>()
                .Property(p => p.name)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Author>()
             .Property(p => p.name)
             .IsRequired()
             .HasMaxLength(150);

            var dataSeeder = new DataSeeder(200, 30, 167824);

            modelBuilder.Entity<Book>().HasData(dataSeeder.GenerateBooksData());
            modelBuilder.Entity<Author>().HasData(dataSeeder.GenerateAuthorData());
        }

    }
}

