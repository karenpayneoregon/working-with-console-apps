using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEntityFrameworkLibrary.Models;

namespace MyEntityFrameworkLibrary.Data.Configurations
{
    public partial class BusinessEntityPhoneConfiguration : IEntityTypeConfiguration<BusinessEntityPhone>
    {
        public void Configure(EntityTypeBuilder<BusinessEntityPhone> entity)
        {
            entity.Property(e => e.BusinessEntityPhoneId).HasColumnName("BusinessEntityPhoneID");

            entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PhoneNumberTypeId).HasColumnName("PhoneNumberTypeID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BusinessEntityPhone> entity);
    }
}
