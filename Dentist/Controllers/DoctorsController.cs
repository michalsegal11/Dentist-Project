
using AutoMapper;
using Dentist.Core.Entities;
using Dentist.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Dentist.Api.Models;
using Dentist.Core;
using Dentist.Core.DTOs;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.AspNetCore.Authorization;
using Dentist.Service;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dentist.API.Controllers
{

    [Route("api/[controller]")]
    [Authorize(Roles = "doctor")]
    [ApiController]
   
    public class doctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public doctorsController(IDoctorService doctorService, IUserService userService, IMapper mapper)
        {
            _doctorService = doctorService;
            _userService = userService;
            _mapper = mapper;
        }




        // GET: api/<doctorsController>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult> Get()
        {

            var doctors =  _doctorService.GetAllAsync();
            await Task.WhenAll(doctors);
            var doctorsDto = _mapper.Map<IEnumerable<DoctorDto>>(doctors.Result);
            return Ok(doctorsDto);

            //var doctors = _doctorService.GetAllAsync();
            
            //return Ok(doctorsDto);

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
        public async Task<ActionResult> Post([FromBody] DoctorPostModel value)
        {
            var user = new User {Id=value.Id, UserName = value.Name, Password = value.Password, Role = eRole.doctor };
            var User1 = await _userService.AddUserAsync(user);
            var newDoctor = _mapper.Map<Doctors>(value);
            newDoctor.user = User1;
            newDoctor.Id = Guid.NewGuid().ToString();
            var doctor = await _doctorService.Get(newDoctor.Id);
            if (doctor != null)
            {
                return Conflict();
            }
            var d = await _doctorService.AddAsync(newDoctor);
            return Ok(d);

        }


        // PUT api/<doctorsController>/5
        [HttpPut("{id}")]

        public async Task<ActionResult> Put(string id, DoctorPostModel value)
        {
            var doctor = _doctorService.Get(value.Id);
            var newDoctor = _mapper.Map<Doctors>(value);
            if (doctor == null)
            {
                return Conflict();
            }
            await _doctorService.UpdateAsync(id, newDoctor);
            return Ok();


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


