﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEntityFrameworkLibrary.Models;

namespace MyEntityFrameworkLibrary.Data.Configurations
{
    public partial class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> entity)
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId })
                .HasName("PK_Order_Details");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.Property(e => e.UnitPrice).HasColumnType("money");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_Order_Details_Orders");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Order_Details_Products");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<OrderDetails> entity);
    }
}
