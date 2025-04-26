using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure;

public class ExContext: DbContext
{
    public DbSet<Laboratoire> Laboratoires { get; set; }
    public DbSet<Bilan> Bilans { get; set; }
    public DbSet<Infirmier> Infirmiers { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Analyse> Analyses { get; set; }
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
        modelBuilder.ApplyConfiguration(new BilanConfig());
    }
}