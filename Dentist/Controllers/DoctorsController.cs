
using Dentist.Core.Entities;
using Dentist.Core.Services;
using Dentist.Service;
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


        // POST api/<doctorsController>
        [HttpPost]
        public Doctors Post([FromBody] Doctors value)
        {
            _doctorService.GetList().Add(value);
            return value;
        }


        // PUT api/<doctorsController>/5
        [HttpPut("{id}")]
        public Doctors Put(string id, [FromBody] Doctors value)
        {
            var index = _doctorService.GetList().FindIndex(e => e.Id == id);
            _doctorService.GetList()[index].Name = value.Name;
            _doctorService.GetList()[index].Adress = value.Adress;
            _doctorService.GetList()[index].Specialization = value.Specialization;
            return _doctorService.GetList()[index];
        }

        // DELETE api/<doctorsController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var index = _doctorService.GetList().FindIndex(e => e.Id == id);
            _doctorService.GetList().Remove(_doctorService.GetList()[index]);
        }


    }
}


