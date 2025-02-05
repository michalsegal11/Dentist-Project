using Dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface IPatientService
    {
  
        public Task<IEnumerable<Patient>> GetAllAsync();

        public Patient Get(int id);

        //public Patient Add(Patient patient);
        public Task<Patient> AddAsync(Patient student);

    }
}
