using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;


namespace api2.Models
{
    [Table("Comments")]
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;        //Entity framework, .Net Core will search through our code and form this relantioship
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        //Navigation property
        //Entity framework will take our database tables and turn them into objects
        //An object is the representation of one row in the database
        public Stock? Stock { get; set; }
    }
}