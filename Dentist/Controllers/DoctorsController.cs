
using AutoMapper;
using Dentist.Core.Entities;
using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Dentist.Api.Models;
using Dentist.Core;
using Dentist.Core.DTOs;
using Microsoft.Extensions.Hosting;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class doctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;


        public doctorsController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }




        // GET: api/<doctorsController>
        [HttpGet]

        public async Task<ActionResult> Get()
        {
         
            //5
            var doctors = _doctorService.GetAllAsync();
            //await Task.WhenAll(x, doctors);
            var doctorsDto = _mapper.Map<IEnumerable<DoctorDto>>(doctors.Result);
            return Ok(doctorsDto);




        }


        [HttpGet("{id}")]
        public ActionResult Get(string id)
        {
            var doctor = _doctorService.Get(id);
            if (doctor == null)
            {
                return NotFound();
            }
            var doctorDto = _mapper.Map<DoctorDto>(doctor);
            return Ok(doctorDto);
        }

        // POST api/<doctorsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DoctorPostModel value)
        {
          
            var doctor  = new Doctors { Name = value.Name, Adress = value.Adress, Specialization = value.Specialization};
            var d = await _doctorService.AddAsync(doctor);
            return Ok(d);

            //var d = await _doctorService.AddAsync(student);
            //return Ok(d);
            //if (doctor == null)
            //{
            //    return Ok(_doctorService.Add(value));
            //}
            //return Conflict();
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


