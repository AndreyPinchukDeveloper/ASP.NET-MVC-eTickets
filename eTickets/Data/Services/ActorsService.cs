using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _appDbContext;
        public ActorsService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(Actor actor)
        {
            await _appDbContext.Actors.AddAsync(actor);
            await _appDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _appDbContext.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIDAsync(int id)
        {
            var result = await _appDbContext.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
