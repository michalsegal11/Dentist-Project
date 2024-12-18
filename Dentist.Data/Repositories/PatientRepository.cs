
using Dentist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Patient> GetAll()
        {
            return _context.patients.Where(s => !string.IsNullOrEmpty(s.Name));
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            return await _context.patients.Where(s => !string.IsNullOrEmpty(s.Name)).Include(s => s.Class).ToListAsync();
        }
        public Patient Get(int id)
        {
            return _context.patients.FirstOrDefault(s => s.Id == id);
        }

        public Patient Add(Patient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }
        public async Task<Patient> AddAsync(Patient patient)
        {
            _context.patients.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }
    }
}
