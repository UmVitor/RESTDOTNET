using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_API.Business;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Model;
using REST_API.Data.VO;

namespace REST_API.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {
       
        private readonly ILogger<PersonController> _logger;
        
        // Declaration of the service used
        private IPersonBusiness _PersonBusiness;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _PersonBusiness = personBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/person
        // Get no parameters for FindAll -> Search All
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_PersonBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _PersonBusiness.FindById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        // Maps POST requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] PersonVO person)
        {
            
            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_PersonBusiness.Create(person));
        }

        // Maps PUT requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] PersonVO person)
        {

            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_PersonBusiness.Update(person));
        }

        // Maps DELETE requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Pat
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _PersonBusiness.Delete(id);

            return NoContent();
        }


    }
}
