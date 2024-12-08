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
        public IEnumerable<Patient> GetList();


        public Patient Get(string id);

        public Patient Add(Patient patient);
    }
}
