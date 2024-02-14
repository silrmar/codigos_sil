using tasca3p.Models;

namespace tasca3p.Repositories.Interfaces
{
    public interface ILanchesRepository
    {
        //coleçao de objetos lanches
        IEnumerable<Lanches> Lanches { get; }

        //obter lanches preferidos  a filtrar
        IEnumerable<Lanches> LanchesPreferidos { get; }

        //obter lanches pelo id
        Lanches GetLanchesById(int lancheId); 

    }
}
