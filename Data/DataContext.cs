using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using gs_net.Models;

namespace gs_net.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                entity.ToTable("Usuarios"); 

                entity.Property(e => e.EmailConfirmedByte).HasColumnName("EmailConfirmed");
                entity.Property(e => e.PhoneNumberConfirmedByte).HasColumnName("PhoneNumberConfirmed");
                entity.Property(e => e.TwoFactorEnabledByte).HasColumnName("TwoFactorEnabled");
                entity.Property(e => e.LockoutEnabledByte).HasColumnName("LockoutEnabled");
            });
        }

        public DbSet<Coral> Coralis { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Localizacao> Localizacaoes { get; set; }
    }
}
