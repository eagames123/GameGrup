using GameGrup.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace GameGrup.Project.DataAccess.Concrete.Entityframework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable(@"Products", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.Name).HasColumnName("Name");
            Property(x => x.SeoUrl).HasColumnName("SeoUrl");
            Property(x => x.CategoryId).HasColumnName("CategoryId");
            Property(x => x.ImageUrl).HasColumnName("ImageUrl");
            Property(x => x.Price).HasColumnName("Price");
            Property(x => x.IsActive).HasColumnName("IsActive");
            Property(x => x.Desciption).HasColumnName("Desciption");
        }
    }
}
