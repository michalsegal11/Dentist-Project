using Dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Repositories
{
    public interface IPatientRepository
    {
        public IEnumerable<Patient> GetAll();

        public Patient Get(int id);

        public Patient Add(Patient patient);
        public Task<IEnumerable<Patient>> GetAllAsync();

        public Task<Patient> AddAsync(Patient student);

    }
}
