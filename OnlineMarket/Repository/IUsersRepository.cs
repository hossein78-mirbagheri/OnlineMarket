using OnlineMarket.Models;

namespace OnlineMarket.Repository
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetAllAsync();
        Task<Users> GetByIdAsync(int id);
        Task Create(Users _Users);
        Task Update(Users _Users);
        Task Delete(int id);
    }
}

