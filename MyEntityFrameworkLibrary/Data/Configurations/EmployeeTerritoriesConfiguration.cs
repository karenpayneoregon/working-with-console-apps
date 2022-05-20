﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEntityFrameworkLibrary.Models;

namespace MyEntityFrameworkLibrary.Data.Configurations
{
    public partial class EmployeeTerritoriesConfiguration : IEntityTypeConfiguration<EmployeeTerritories>
    {
        public void Configure(EntityTypeBuilder<EmployeeTerritories> entity)
        {
            entity.HasKey(e => new { e.EmployeeId, e.TerritoryId })
                .IsClustered(false);

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.TerritoryId)
                .HasMaxLength(20)
                .HasColumnName("TerritoryID");

            entity.HasOne(d => d.Employee)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Employees");

            entity.HasOne(d => d.Territory)
                .WithMany(p => p.EmployeeTerritories)
                .HasForeignKey(d => d.TerritoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EmployeeTerritories_Territories");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EmployeeTerritories> entity);
    }
}
