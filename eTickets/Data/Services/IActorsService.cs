using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActorsAsync();
        Task<Actor> GetByIDAsync(int id);
        Task AddAsync(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
