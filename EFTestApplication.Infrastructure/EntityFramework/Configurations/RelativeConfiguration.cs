using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFTestApplication.Infrastructure.EntityFramework.Configurations
{
    public class RelativeConfiguration : IEntityTypeConfiguration<Relative>
    {
        public void Configure(EntityTypeBuilder<Relative> builder)
        {
            builder.ToTable(nameof(Relative), PersonsContext.DefaultSchemaName);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Relation).IsRequired();
        }
    }
}