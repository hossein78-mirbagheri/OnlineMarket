using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public DateTime TransactionDate { get; set; }
        public Users Buyer { get; set; }
    }
}
