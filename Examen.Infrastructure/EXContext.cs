using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure;

public class EXContext: DbContext
{
    public DbSet<Laboratoire> Laboratoires { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DAC444V;Initial Catalog=Lab;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Laboratoire>()
            .Property(l => l.Localisation)
            .HasColumnName("AdresseLabo")
            .HasMaxLength(50);
    }
}