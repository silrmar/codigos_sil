using Microsoft.EntityFrameworkCore;
using tasca3p.Context;
using tasca3p.Models;
using tasca3p.Repositories.Interfaces;

namespace tasca3p.Repositories
{
    public class LanchesRepository : ILanchesRepository
    {
        private readonly AppDbContext _context;

        public LanchesRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Lanches> Lanches => _context.Lanches.Include(c => c.Categorias);

        public IEnumerable<Lanches> LanchesPreferidos => _context.Lanches.
            Where(l => l.IsLanchePreferido)
            .Include(c =>c.Categorias);

        public Lanches GetLanchesById(int lancheId)
        {
            var lanche = _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
            return lanche != null ? lanche : throw new Exception("Lanche não encontrado.");
           // return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

        }


    }
}
