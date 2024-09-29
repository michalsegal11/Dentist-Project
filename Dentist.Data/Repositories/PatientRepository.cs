
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
        public List<Patient> GetAll()
        {
            return _context.patients.ToList();
        }
    }
}
