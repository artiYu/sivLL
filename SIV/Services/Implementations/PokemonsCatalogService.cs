using API.Services.Interfaces;
using SIV;

namespace API.Services.Implementations
{
    public class PokemonsCatalogService : IPokemonsCatalogService
    {
        public IEnumerable<PokemonsCatalog> GetPokemonsAll()
        {
            using(SIVContext context = new SIVContext())
            {
                return context.PokemonsCatalogs.ToList();
            }
        }

        public PokemonsCatalog GetPokemonById(int id)
        {
            using(SIVContext context = new SIVContext())
            {
                return context.PokemonsCatalogs.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
