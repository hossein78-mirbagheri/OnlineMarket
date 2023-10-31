using System.Data;

namespace OnlineMarket.Data
{
    public interface IMarketDbContext
    {
        IDbConnection CreateConnection();
    }
}
