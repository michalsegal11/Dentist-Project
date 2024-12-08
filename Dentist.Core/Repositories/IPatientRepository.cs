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

        public Patient Get(string id);

        public Patient Add(Patient patient);


    }
}
