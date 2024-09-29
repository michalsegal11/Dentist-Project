using Dentist.Core.Entities;
using Dentist.Core.Repositories;
using Dentist.Data;
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
        public List<Doctors> GetAll()
        {
            return _context.doctor.ToList();
        }
    }
}
