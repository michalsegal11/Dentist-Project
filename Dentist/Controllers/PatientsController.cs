using AutoMapper;
using Dentist.API.Models;
using Dentist.Core.DTOs;
using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        public readonly IPatientService _context;
        public readonly IMapper _mapper;

        public PatientsController(IPatientService context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    

        // GET: api/<PatientsController>
        [HttpGet]
        public async  Task<ActionResult> Get()
        {
            var patients = _context.GetAllAsync();
            await Task.WhenAll(patients);
            var patientDro = _mapper.Map<IEnumerable<PatientDto>>(patients.Result);
            return Ok(patientDro);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var patient = _context.Get(id);
            if (patient == null)
            {
                return NotFound();
            }
            var patientDto=_mapper.Map<PatientDto>(patient);
            return Ok(patientDto);
        }




        // POST api/<PatientsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] PatientPostModel p)
        {
            //var patient =new Patient.Get(p.Id);
            //if (student == null)
            //{
            //    return Ok(_context.Add(p));
            //}
            //return Conflict();
            var patient = new Patient { Name = p.Name, DateBorn = p.DateBorn, Age = p.Age, Status = p.Status, turn = p.turn };
            var pat = await _context.AddAsync(patient);
            return Ok(pat);

        }

        // PUT api/<PatientsController>/5
        [HttpPut("{id}")]
        public Patient Put(int id, [FromBody] Patient value)
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
        public void Delete(int id)
        {
            var index = _context.Get(id);
            index.Status = false;
        }
    }
}
