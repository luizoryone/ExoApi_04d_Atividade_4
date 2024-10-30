using ExoApi.Domains;
using Microsoft.EntityFrameworkCore; // inserido do DbContext

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
                //Data Source: serve name no ssms - unitial catalog = nome databank no ssms - 
            }
        }

        // Propriedade DbSet para a tabela Projetos
        public DbSet<Projetos> Projetos { get; set; }
    }
}
