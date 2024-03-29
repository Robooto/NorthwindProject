﻿using NorthwindProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            HasKey(t => t.Id);

            Property(t => t.ProductName).IsRequired().HasMaxLength(40);
            Property(t => t.QuantityPerUnity).HasMaxLength(20);

            ToTable("Products");

            Property(t => t.Id).HasColumnName("ProductID");
            Property(t => t.ProductName).HasColumnName("ProductName");
            Property(t => t.CategoryId).HasColumnName("CategoryId");
            Property(t => t.QuantityPerUnity).HasColumnName("QuantityPerUnit");
            Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");

            HasOptional(t => t.Category).WithMany(t => t.Products).HasForeignKey(d => d.CategoryId);
        }
    }
}
