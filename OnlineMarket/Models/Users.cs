using OnlineMarket.Models;
using System.Transactions;

namespace OnlineMarket.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public List<Product> Products { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
