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
        public IEnumerable<Patient> Get()
        {
           return _context.GetList();
        }

        // GET api/<PatientsController>/5
        //[HttpGet("{id}")]
        //public  Patient Get(string id)
        //{
        //    var index= patients.FindIndex(e=> e.Id == id);
        //    return index;

        //}

        // POST api/<PatientsController>
        [HttpPost]
        public Patient Post([FromBody] Patient value)
        {
            _context.GetList().Add(value);
            return value;
        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public Patient Put(string id, [FromBody] Patient value)
        {
            var index = _context.GetList().FindIndex(e => e.Id == id);
            _context.GetList()[index].Id = value.Id;
            _context.GetList()[index].Name = value.Name;
            _context.GetList()[index].DateBorn = value.DateBorn;
            _context.GetList()[index].Age = value.Age;
            return _context.GetList()[index];
        }


      

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = _context.GetList().FindIndex(e => e.Id == id);
            _context.GetList()[index].Status = false;
        }
    }
}
