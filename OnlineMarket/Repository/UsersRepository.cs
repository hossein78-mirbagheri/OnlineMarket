using Dapper;
using OnlineMarket.Data;
using OnlineMarket;
using OnlineMarket.Models;
using OnlineMarket.Repository;
using System.Data;

namespace OnlineMarket.Repository
{
    public class UsersRepository
    {

    }

namespace DapperCRUD.Repository
    {
        public class UsersRepository : IUsersRepository
        {
            private readonly IMarketDbContext _context;
            public UsersRepository(IMarketDbContext context)
            {
                _context = context;
            }

            public async Task Create(Users _Users)
            {
                var query = "INSERT INTO " + typeof(Users).Name + " (Id, Username,Role,Products,Transactions) VALUES (@Id, @Username,@Role,@Products,@Transactions)";
                var parameters = new DynamicParameters();
                parameters.Add("Id", _Users.Id, DbType.String);
                parameters.Add("Username", _Users.Username, DbType.String);
                parameters.Add("Role", _Users.Role, DbType.String);
                parameters.Add("Products", _Users.Products, DbType.String);
                parameters.Add("Transactions", _Users.Transactions, DbType.String);


                using var connection = _context.CreateConnection();

                await connection.ExecuteAsync(query, parameters);
            }

           

            public async Task Delete(int id)
            {
                var query = "DELETE FROM " + typeof(Users).Name + " WHERE Id = @Id";
                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, new { id });
                }
            }

            public async Task<IEnumerable<Users>> GetAllAsync()
            {

                var query = "select * from Users";
                using (var connection = _context.CreateConnection())
                {
                    var result = await connection.QueryAsync<Users>(query);
                    return result.ToList();
                }
            }

            public async Task<Users> GetByIdAsync(int id)
            {
                var query = "select * from Users as br WHERE br.Id = @Id"; ;

                using (var connection = _context.CreateConnection())
                {
                    var result = await connection.QuerySingleOrDefaultAsync<Users>(query, new { id });
                    return result;
                }
            }

            public async Task Update(Users _Users)
            {
                var query = "UPDATE Branch SET Id = @Id, Username =@Username,Role =@Role,Products =@Products,Transactions =@Transactions    WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", _Users.Id, DbType.String);
                parameters.Add("Username", _Users.Username, DbType.String);
                parameters.Add("Role", _Users.Role, DbType.String);
                parameters.Add("Products", _Users.Products, DbType.String);
                parameters.Add("Transactions", _Users.Transactions, DbType.String);


                using (var connection = _context.CreateConnection())
                {
                    await connection.ExecuteAsync(query, parameters);
                }
            }

        }
    }

}
