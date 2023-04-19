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

        public void Add(Actor actor)
        {
            _appDbContext.Actors.Add(actor);
            _appDbContext.SaveChanges();
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

        public Actor GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
