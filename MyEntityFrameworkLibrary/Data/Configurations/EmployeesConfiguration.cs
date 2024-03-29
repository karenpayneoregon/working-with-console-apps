﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEntityFrameworkLibrary.Models;

namespace MyEntityFrameworkLibrary.Data.Configurations
{
    public partial class EmployeesConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> entity)
        {
            entity.HasKey(e => e.EmployeeId);

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            entity.Property(e => e.Address).HasMaxLength(60);

            entity.Property(e => e.BirthDate).HasColumnType("datetime");

            entity.Property(e => e.City).HasMaxLength(15);

            entity.Property(e => e.Extension).HasMaxLength(4);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.HireDate).HasColumnType("datetime");

            entity.Property(e => e.HomePhone).HasMaxLength(24);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.Region).HasMaxLength(15);

            entity.Property(e => e.TitleOfCourtesy).HasMaxLength(25);

            entity.HasOne(d => d.ContactTypeIdentifierNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.ContactTypeIdentifier)
                .HasConstraintName("FK_Employees_ContactType");

            entity.HasOne(d => d.CountryIdentifierNavigation)
                .WithMany(p => p.Employees)
                .HasForeignKey(d => d.CountryIdentifier)
                .HasConstraintName("FK_Employees_Countries");

            entity.HasOne(d => d.ReportsToNavigation)
                .WithMany(p => p.InverseReportsToNavigation)
                .HasForeignKey(d => d.ReportsTo)
                .HasConstraintName("FK_Employees_Employees");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Employees> entity);
    }
}
