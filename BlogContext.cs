using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirstNew
{
    public class BlogContext : DbContext
    {
        public BlogContext()
        {
        }
        public BlogContext(DbContextOptions<BlogContext> options)
        : base(options) { }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=.;Database = CodeFirstNew; Trusted_Connection=True;MultipleActiveResultSets=True;Integrated Security=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
