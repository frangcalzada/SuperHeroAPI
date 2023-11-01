using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeros()
        {
            var result = await _superHeroService.GetAllHeros();
            if (result is null) return NotFound("I'm sorry but there are no loaded superheroes");
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = await _superHeroService.GetSingleHero(id);
            if (result is null) return NotFound("Sorry, but this hero doesn't exist.");
            return Ok(result);
        }

        //Agregar validaciones
        //Agregar validaciones y ver como editar bien los campos, tmb agregar que en este caso es para lista, cambiar tmb lo que devuelve ok
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = await _superHeroService.AddHero(hero);
            return Ok(result);
        }

        //Agregar validaciones y ver como editar bien los campos, tmb agregar que en este caso es para lista, cambiar tmb lo que devuelve ok
        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = await _superHeroService.UpdateHero(id, request);
            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);
        }

        //Agregar validaciones y ver como editar bien los campos, tmb agregar que en este caso es para lista, cambiar tmb lo que devuelve ok
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var result = await _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound("Hero not found");

            return Ok(result);
        }
    }
}
