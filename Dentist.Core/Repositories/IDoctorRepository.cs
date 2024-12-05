
using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Repositories
{
    public interface IDoctorRepository
    {
        public IEnumerable<Doctors> GetAll();

        public Doctors Get(string id);

        public Doctors Add(Doctors doctors);
    }
}
