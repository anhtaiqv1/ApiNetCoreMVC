using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class LaguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Language");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.IsDefault).IsRequired();
            builder.HasKey(x => x.Id);
        }
    }
}
