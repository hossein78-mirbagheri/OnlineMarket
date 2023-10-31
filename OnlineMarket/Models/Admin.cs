using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models
{
    public class Admin
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Username  { get; set; }
    }
}
