using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWASMDemo.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroRepository _heroRepository;

        public HeroController(HeroRepository heroRepository)
        {
            _heroRepository = heroRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Hero>>> GetHeroes()
        {
            var heroes = await _heroRepository.GetAllHeroesAsync();
            return Ok(heroes);
        }

        [HttpPost]
        public async Task<IActionResult> PostHero(Hero entity)
        {
            var result = await _heroRepository.CreateHeroAsync(entity);
            return result ? Ok() : BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHeroAsync(int id)
        {
            _heroRepository.DeleteHero(id);
            return Ok();
        }
    }
}
