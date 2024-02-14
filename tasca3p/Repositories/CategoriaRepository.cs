using System.Runtime.CompilerServices;
using tasca3p.Context;
using tasca3p.Models;
using tasca3p.Repositories.Interfaces;

namespace tasca3p.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto; //instância do contexto
        }

        public IEnumerable<Categorias> Categorias => _context.Categorias; //usar a instância para aceder à tabela categorias

    }
}
