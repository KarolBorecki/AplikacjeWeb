using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookshelfAPI.Models;

    public class AuthorsContext : DbContext
    {
        public AuthorsContext (DbContextOptions<AuthorsContext> options)
            : base(options)
        {
        }

        public DbSet<BookshelfAPI.Models.Author> Authors { get; set; } = default!;
    }
