
using Dentist.Core.Entities;
using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class doctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;


        public doctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }




        // GET: api/<doctorsController>
        [HttpGet]

        public ActionResult Get()
        {
            return Ok(_doctorService.GetList());
        }


        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var doctor = _doctorService.Get(id);
            if (doctor == null)
            {
                return NotFound();
            }
            return Ok(doctor);
        }

        // POST api/<doctorsController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctors value)
        {

            var doctor = _doctorService.Get(value.Id);
            if (doctor == null)
            {
                return Ok(_doctorService.Add(value));
            }
            return Conflict();
        }


        // PUT api/<doctorsController>/5
        [HttpPut("{id}")]
        public Doctors Put(string id, [FromBody] Doctors value)
        {
            var doctor = _doctorService.Get(value.Id);
            doctor.Name = value.Name;
            doctor.Adress = value.Adress;
            doctor.Specialization = value.Specialization;
            return doctor;
        }

        // DELETE api/<doctorsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            //var index = _doctorService.GetList().FindIndex(e => e.Id == id);
            //_doctorService.GetList().Remove(_doctorService.GetList()[index]);
        }


    }
}


