using OnlineMarket.Models;

namespace OnlineMarket.Repository
{
    public interface IAdminRepository
    {
        Task<IEnumerable<Admin>> GetAllAsync();
        Task<Admin> GetByIdAsync(int id);
        Task Create(Admin _Admin);
        Task Update(Admin _Admin);
        Task Delete(int id);
    }
}
