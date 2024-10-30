using ExoApi.Contexts;
using ExoApi.Domains;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoApiContext _ctx;

        public ProjetoRepository(ExoApiContext ctx)
        {
            _ctx = ctx;
        }

        public List<Projetos> Listar() // get
        {
            // Em SQL: select * from  Projetos  
            return _ctx.Projetos.ToList();
        }
    }
}

