using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                Priorty = 1,
                ParentId = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category category2 = new()
            {
                Id = 1,
                Name = "Moda",
                Priorty = 1,
                ParentId = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priorty = 2,
                ParentId = 0,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priorty = 1,
                ParentId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            builder.HasData(category1, category2, parent1, parent2);

        }
    }
}
