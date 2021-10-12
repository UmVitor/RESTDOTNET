using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_API.Services;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REST_API.Model;

namespace REST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
       
        private readonly ILogger<PersonController> _logger;
        
        // Declaration of the service used
        private IPersonService _PersonService;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _PersonService = personService;
        }

        // Maps GET requests to https://localhost:{port}/api/person
        // Get no parameters for FindAll -> Search All
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_PersonService.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _PersonService.FindById(id);
            if (person == null)
            {
                return NotFound();
            }
            return Ok(person);
        }

        // Maps POST requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            
            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_PersonService.Create(person));
        }

        // Maps PUT requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {

            if (person == null)
            {
                return BadRequest();
            }
            return Ok(_PersonService.Update(person));
        }

        // Maps DELETE requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Pat
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _PersonService.Delete(id);

            return NoContent();
        }


    }
}
