using Microsoft.EntityFrameworkCore;

namespace RamallScheffer.Date
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Ramall> Ramais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Ramall>().HasData(
          new Ramall
          {
            Id = 1,
            Setor = "Tecnologia da Informação",
            NumeroRamall = "239",
            Funcionarios = "Denyson"
          },
          new Ramall
          {
            Id = 2,
            Setor = "Tecnologia da Informação",
            NumeroRamall = "244",
            Funcionarios = "Sato"
          }
      );
    }
  }
}
//"Denyson/Gabriel/Ramon", "Sato/Dennis/Jefferson/Luan/Nicholas"