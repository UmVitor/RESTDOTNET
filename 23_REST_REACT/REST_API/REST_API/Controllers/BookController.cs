using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using REST_API.Business;
using System.Collections.Generic;
using REST_API.Data.VO;
using REST_API.Hypermedia.Filters;
using Microsoft.AspNetCore.Authorization;

namespace REST_API.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
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
        [HttpGet("{sortDirection}/{pageSize}/{page}")]
        [ProducesResponseType((200), Type = typeof(List<BookVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(
            [FromQuery] string title,
            string sortDirection,
            int pageSize,
            int page)
        {
            return Ok(_BookBusiness.FindWithPagedSearch(title, sortDirection, pageSize, page));
        }

        // Maps GET requests to https://localhost:{port}/api/person/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
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
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _BookBusiness.Delete(id);

            return NoContent();
        }


    }
}
