using SIV;

namespace API.Services.Interfaces
{
    public interface IPokemonsCatalogService
    {
        IEnumerable<PokemonsCatalog> GetPokemonsAll();
        PokemonsCatalog GetPokemonById(int id);
    }
}
