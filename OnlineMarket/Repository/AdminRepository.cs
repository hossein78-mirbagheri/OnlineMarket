using Dapper;
using OnlineMarket.Data;
using OnlineMarket;
using OnlineMarket.Models;
using OnlineMarket.Repository;
using System.Data;

namespace OnlineMarket.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly IMarketDbContext _context;
        public AdminRepository(IMarketDbContext context)
        {
            _context = context;
        }

        public async Task Create(Admin _Admin)
        {
            var query = "INSERT INTO " + typeof(Admin).Name + " (Id, Username) VALUES (@Id, @Username)";
            var parameters = new DynamicParameters();
            parameters.Add("Id", _Admin.Id, DbType.String);
            parameters.Add("Username", _Admin.Username, DbType.String);
        
            using var connection = _context.CreateConnection();

            await connection.ExecuteAsync(query, parameters);
        }

        public async Task Delete(int id)
        {
            var query = "DELETE FROM " + typeof(Admin).Name + " WHERE Id = @Id";
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, new { id });
            }
        }

        public async Task<IEnumerable<Admin>> GetAllAsync()
        {

            var query = "select * from Admin";
            using var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<Admin>(query);
            return result.ToList();
        }

        public async Task<Admin> GetByIdAsync(int id)
        {
            var query = "select * from Admin as br WHERE br.Id = @Id";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QuerySingleOrDefaultAsync<Admin>(query, new { id });
                return result;
            }
        }

        public async Task Update(Admin _Admin)
        {
            var query = "UPDATE Admin SET Id = @Id, Username =@Username WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", _Admin.Id, DbType.String);
            parameters.Add("Username", _Admin.Username, DbType.String);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

    }
}
