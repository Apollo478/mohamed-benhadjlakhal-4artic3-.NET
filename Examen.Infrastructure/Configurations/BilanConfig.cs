using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Examen.Infrastructure.Configurations;

public class BilanConfig : IEntityTypeConfiguration<Bilan>
{
    public void Configure(EntityTypeBuilder<Bilan> builder)
    {
        builder.HasKey(b => new { b.CodePatient, b.InfirmierId, b.DatePrievement });
        builder.HasOne(b => b.Patient)
            .WithMany()
            .HasForeignKey(b => b.CodePatient);
        builder.HasOne(b => b.Infirmier)
            .WithMany()
            .HasForeignKey(b => b.InfirmierId);
    }
}