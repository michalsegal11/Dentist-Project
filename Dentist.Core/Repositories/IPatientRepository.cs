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
        public List<Patient> GetAll();
    }
}
