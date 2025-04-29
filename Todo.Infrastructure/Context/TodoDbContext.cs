using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todo.Domain.Entities;

namespace Todo.Infrastructure.Context
{
    public class TodoDbContext:DbContext
    {
       public TodoDbContext(DbContextOptions<TodoDbContext> options ):base(options) { 
        
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Category> CategoryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TodoDbContext).Assembly);
        }
    }
}
