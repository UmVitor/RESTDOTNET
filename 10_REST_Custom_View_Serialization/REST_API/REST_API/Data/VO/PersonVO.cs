using REST_API.Model.Base;
using System.Text.Json.Serialization;

namespace REST_API.Data.VO
{

    //Let's do the custom serialization, for change the JSON sended like we desire
    public class PersonVO
    {
 
        [JsonPropertyName("code")] // will change the name of atribuitatribute
        public long Id { get; set; }
        [JsonPropertyName("name")] // will change the name of atribuitatribute
        public string FirstName { get; set; }
        [JsonPropertyName("last_name")] // will change the name of atribuitatribute
        public string LastName { get; set; }
        [JsonIgnore] // will ignore the Address, and don't will be serialized
        public string Address { get; set; }
        [JsonPropertyName("sex")]
        public string Gender { get; set; }

    }
}
