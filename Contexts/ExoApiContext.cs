using ExoApi.Domains;
using Microsoft.EntityFrameworkCore;

namespace ExoApi.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext() { }

        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options) { }

        // Configuração do banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESK_I5\\SQLEXPRESS; initial catalog=ExoApi; integrated Security=True; TrustServerCertificate=True");
            }
        }

        // Propriedade DbSet para a tabela Projetos
        public DbSet<Projetos> Projetos { get; set; }
    }
}
