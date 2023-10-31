using OnlineMarket.Models;

namespace OnlineMarket.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public List<Product> PurchasedProducts { get; set; }
        public List<Transaction> Transactions { get; set; }
        public Users UserProfile { get; set; }
    }

}