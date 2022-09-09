using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SIV;

namespace API.Controllers
{
    [ApiVersionNeutral]
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PokemonsCatalogController
    {
        private IPokemonsCatalogService pokemonsCatalogService;

        public PokemonsCatalogController(IPokemonsCatalogService pokemonsCatalogService)
        {
            this.pokemonsCatalogService = pokemonsCatalogService;
        }

        [HttpGet, Route("")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PokemonsCatalog))]
        public IActionResult GetPokemonsAll()
        {
            return new OkObjectResult(pokemonsCatalogService.GetPokemonsAll());
        }

        [HttpGet, Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PokemonsCatalog))]
        public IActionResult GetPokemonsAll(int id)
        {
            return new OkObjectResult(pokemonsCatalogService.GetPokemonById(id));
        }
    }
}
