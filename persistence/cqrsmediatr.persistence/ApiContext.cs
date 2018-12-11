using System;
using Microsoft.EntityFrameworkCore;
using cqrsmediatr.domain.models;

namespace cqrsmediatr.persistence
{
    public class ApiContext : DbContext
    {
        public ApiContext (DbContextOptions<ApiContext> options) : base(options)
        {
        }
        
        public DbSet<TodoItem> TodoItem {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(schema: "Todo");
            modelBuilder.Entity<TodoItem>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
