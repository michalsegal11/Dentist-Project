using Dentist.Core.Entities;
using Dentist.Core.Repositories;
using Dentist.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dentist.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Doctors> GetAll()
        {
            return _context.doctor.Where(s => !string.IsNullOrEmpty(s.Name)) ;
        }

        public Doctors Get(string id)
        {
            return _context.doctor.FirstOrDefault(s => s.Id == id);
        }

        public Doctors Add(Doctors doctors)
        {
            _context.doctor.Add(doctors);
            _context.SaveChanges();
            return doctors;
        }
        public async Task<IEnumerable<Doctors>> GetAllAsync()
        {
            return await _context.doctor.Where(s => !string.IsNullOrEmpty(s.Name)).Include(s => s.Id).ToListAsync();
        }

        public async Task<Doctors> AddAsync(Doctors doctor)
        {
            _context.doctor.Add(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }
    }
}
