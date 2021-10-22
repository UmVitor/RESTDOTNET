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
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;

        // Declaration of the service used
        private IBookBusiness _BookBusiness;

        // Injection of an instance of IPersonService
        // when creating an instance of PersonController
        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            _BookBusiness = bookBusiness;
        }

        // Maps GET requests to https://localhost:{port}/api/person
        // Get no parameters for FindAll -> Search All
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_BookBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _BookBusiness.FindById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // Maps POST requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] BookVO book)
        {

            if (book == null)
            {
                return BadRequest();
            }
            return Ok(_BookBusiness.Create(book));
        }

        // Maps PUT requests to https://localhost:{port}/api/person/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] BookVO book)
        {

            if (book == null)
            {
                return BadRequest();
            }
            return Ok(_BookBusiness.Update(book));
        }

        // Maps DELETE requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Pat
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _BookBusiness.Delete(id);

            return NoContent();
        }


    }
}
