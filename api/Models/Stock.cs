using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using api2.Models;


namespace api.Models
{
    [Table("Stocks")]
    public class Stock
    {
         
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")] //it meand that the price amount can have only 18 digits and 2 decimal places
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")] //it meand that the price amount can have only 18 digits and 2 decimal places
        public decimal LastDiv { get; set; }
        public string Industry { get; set; } = string.Empty;
        public long MarketCap { get; set; }
        

        public List<Comment> Comments { get; set; } = new List<Comment>();
        public List<Portfolio> Portfolios {get; set;} = new List<Portfolio>();

    }
}