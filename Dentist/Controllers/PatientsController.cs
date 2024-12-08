using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        public readonly IPatientService _context;

        public PatientsController(IPatientService context)
        {
            _context = context;
        }

        // GET: api/<PatientsController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_context.GetList());
        }

        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var student = _context.Get(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }




        // POST api/<PatientsController>
        [HttpPost]
        public ActionResult Post([FromBody] Patient p)
        {
            var student = _context.Get(p.Id);
            if (student == null)
            {
                return Ok(_context.Add(p));
            }
            return Conflict();

        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public Patient Put(string id, [FromBody] Patient value)
        {
            var index = _context.Get(id);
            index.Id = value.Id;
            index.Name = value.Name;
            index.DateBorn = value.DateBorn;
            index.Age = value.Age;
            return index;
        }



        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = _context.Get(id);
            index.Status = false;
        }
    }
}
