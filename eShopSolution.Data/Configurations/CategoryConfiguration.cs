using eShopSolution.Data.Entities;
using eShopSolution.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Status).IsRequired().HasDefaultValue(Status.Active);
            builder.Property(x=>x.SortOrder).IsRequired().HasDefaultValue(0);   
            builder.Property(x=>x.IsShowOnHome ).IsRequired().HasDefaultValue(0);


        }
    }
}
