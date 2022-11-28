using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.Core.Models;
using System;

namespace RepositoryPatternWithUOW.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
