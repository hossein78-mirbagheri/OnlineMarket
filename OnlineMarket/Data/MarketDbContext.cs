using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnlineMarket.Models;
using System.Collections.Generic;
using System.Data;

namespace OnlineMarket.Data
{
    //public class MarketDbContext: DbContext
    //{

    //    public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
    //    {

    //    }
    //    public DbSet<Admin> Admin { get; set; }
    //    public DbSet<Users> Users { get; set; }
    //    public DbSet<Product> Products { get; set; }
    //    public DbSet<Transaction> Transactions { get; set; }



    //}
    public class MarketDbContext : IMarketDbContext
    {
        private readonly IConfiguration _iConfiguration;
        private readonly string _connString;
        public MarketDbContext(IConfiguration iConfiguration)
        {
            _iConfiguration = iConfiguration;
            _connString = _iConfiguration.GetConnectionString("connMSSQL");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connString);
    }
}
