using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_API.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Author { get; set; }       
        public DateTime Launch_Date { get; set; }       
        public decimal Price { get; set; }      
        public string Title { get; set; }

    }
}
