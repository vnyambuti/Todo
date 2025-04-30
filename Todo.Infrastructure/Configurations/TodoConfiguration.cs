
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todo.Domain.Entities;

namespace Todo.Infrastructure.Configurations
{
    public class TodoConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Note).IsRequired().HasMaxLength(500);
            builder.Property(x => x.IsDone).IsRequired();
            builder.Property(x => x.DueDate).IsRequired(false);
            builder.HasOne(x => x.Category).WithMany(x=>x.TodoItems).HasForeignKey(x=>x.categoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasData(
                new TodoItem
                {
Id = 1, 
Title = "First Todo",
Note="First todo",
IsDone = false,
DueDate = DateTime.UtcNow.AddDays(1),
categoryId = 1,
CreatedAt = DateTime.UtcNow,
UpdatedAt = DateTime.UtcNow,


                },
                                new TodoItem
                                {
                                    Id = 1,
                                    Title = "Second Todo",
                                    Note = "Second todo",
                                    IsDone = true,
                                    DueDate = DateTime.UtcNow.AddDays(1),
                                    categoryId = 4,
                                    CreatedAt = DateTime.UtcNow,
                                    UpdatedAt = DateTime.UtcNow,


                                },
                                                new TodoItem
                                                {
                                                    Id = 1,
                                                    Title = "Third Todo",
                                                    Note = "Third todo",
                                                    IsDone = true,
                                                    DueDate = DateTime.UtcNow.AddDays(1),
                                                    categoryId = 2,
                                                    CreatedAt = DateTime.UtcNow,
                                                    UpdatedAt = DateTime.UtcNow,


                                                },
                                                                new TodoItem
                                                                {
                                                                    Id = 1,
                                                                    Title = "Fourth Todo",
                                                                    Note = "Fourth todo",
                                                                    IsDone = false,
                                                                    DueDate = DateTime.UtcNow.AddDays(1),
                                                                    categoryId = 2,
                                                                    CreatedAt = DateTime.UtcNow,
                                                                    UpdatedAt = DateTime.UtcNow,


                                                                }
                );
        }
    }
}
