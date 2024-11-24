using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class turnsController : ControllerBase
    {
        public readonly ITurnServices _context;

        public turnsController(ITurnServices context)
        {
            _context = context;
        }


        // GET: api/<turnsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.getAll());
        }

        // GET api/<turnsController>/5
        [HttpGet("{Code}")]
        public turn Get(string Code)
        {
            var index = _context.getAll().FindIndex(e => e.Id.Equals(Code));
            return _context.getAll()[index];
        }

        // POST api/<turnsController>
        [HttpPost]
        public turn Post([FromBody] turn value)
        {
            _context.getAll().Add(value);
            return value;
        }

    

        // PUT api/<turnsController>/5
        [HttpPut("{Code}")]
        public turn Put(string Code, [FromBody] turn value)
        {
            var index = _context.getAll().FindIndex(e => e.Id.Equals(Code));
            _context.getAll()[index].IdPatient = value.IdPatient;
            _context.getAll()[index].IdDentist = value.IdDentist;
            _context.getAll()[index].Hour = value.Hour;
            _context.getAll()[index].Date = value.Date;
            return _context.getAll()[index];
        }

        // DELETE api/<turnsController>/5
        [HttpDelete("{Code}")]
        public void Delete(string Code)
        {
            var index = _context.getAll().FindIndex(e => e.Id.Equals(Code));
            _context.getAll().Remove(_context.getAll()[index]);
        }
    }
}
