using REST_API.Hypermedia;
using REST_API.Hypermedia.Abstract;
using REST_API.Model.Base;
using System.Collections.Generic;

namespace REST_API.Data.VO
{
    public class PersonVO : ISupportsHyperMedia
    {
 
        public long Id { get; set; }
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        
        public string Address { get; set; }
        
        public string Gender { get; set; }

        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
