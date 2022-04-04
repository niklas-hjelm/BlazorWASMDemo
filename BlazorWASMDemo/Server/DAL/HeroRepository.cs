using Microsoft.EntityFrameworkCore;

namespace BlazorWASMDemo.Server.DAL
{
    public class HeroRepository
    {
        private readonly HeroContext _heroContext;

        public HeroRepository(HeroContext heroContext)
        {
            _heroContext = heroContext;
        }

        public async Task<bool> CreateHeroAsync(Hero? hero)
        {
            if (hero is null)
            {
                return false;
            }

            if (GetHero(hero.Id) is not null)
                return false;
            await _heroContext.Heroes.AddAsync(hero);
            await _heroContext.SaveChangesAsync();
            return true;
        }

        public async Task<ICollection<Hero>> GetAllHeroesAsync()
        {
            var heroes =  _heroContext.Heroes;
            return await heroes.ToListAsync();
        }

        public Hero? GetHero(int id)
        {
            return _heroContext.Heroes.FirstOrDefault(h => h.Id == id);
        }
        public bool DeleteHero(int id)
        {
            var heroToDelete = GetHero(id);
            if (heroToDelete is null)
            {
                return false;
            }

            _heroContext.Heroes.Remove(heroToDelete);
            _heroContext.SaveChanges();
            return true;
        }
    }
}
