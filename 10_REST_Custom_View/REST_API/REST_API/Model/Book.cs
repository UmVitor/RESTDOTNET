using System;
using System.ComponentModel.DataAnnotations.Schema;
using REST_API.Model.Base;

namespace REST_API.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
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
