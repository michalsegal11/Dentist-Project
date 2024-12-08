
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
        public Patient Get(string id)
        {
            return _context.patients.FirstOrDefault(s => s.Id == id);
        }

        public Patient Add(Patient patient)
        {
            _context.patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }
    }
}
