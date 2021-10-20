using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace REST_API.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public DateTime Launch_Date { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("title")]
        public string Title { get; set; }

    }
}
