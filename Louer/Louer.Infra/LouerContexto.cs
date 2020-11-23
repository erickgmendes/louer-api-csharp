using Louer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace Louer.Infra
{
    public class LouerContexto : DbContext
    {
        public LouerContexto(DbContextOptions<LouerContexto> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySQL("Server=localhost;User Id=root;Password=root;Database=louer");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public DbSet<TipoCliente> TiposCliente { get; set; }
        public DbSet<TipoEmail> TiposEmail { get; set; }
        public DbSet<TipoTelefone> TiposTelefone { get; set; }
        public DbSet<TipoPessoa> TiposPessoa { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteTelefone> ClientesTelefone { get; set; }
        public DbSet<ClienteEmail> ClientesEmail { get; set; }
        public DbSet<ClienteReferencia> ClientesReferencia { get; set; }
    }
}
