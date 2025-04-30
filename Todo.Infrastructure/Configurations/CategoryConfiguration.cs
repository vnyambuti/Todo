using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Todo.Domain.Entities;
using Todo.Infrastructure.Context;

namespace Todo.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired().HasMaxLength(256);
            builder.Property(x => x.Description).HasMaxLength(256);

            builder.HasData(
                new Category
                {
                    Id=1,
                    Name="Work",
                    Description="Work related task"
                },
                   new Category
                   {
                       Id = 1,
                       Name = "School",
                       Description = "School related task"
                   },
                      new Category
                      {
                          Id = 1,
                          Name = "Hobby",
                          Description = "Hobby related task"
                      },
                         new Category
                         {
                             Id = 1,
                             Name = "Church",
                             Description = "Church related task"
                         },
                            new Category
                            {
                                Id = 1,
                                Name = "Volunteer",
                                Description = "Volunteer related task"
                            }

                );
        }
    }
}
