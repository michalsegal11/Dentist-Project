

using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface IDoctorService
    {
        public IEnumerable<Doctors> GetList();
        public Doctors Get(string id);
        public Doctors Add(Doctors doctor);

        public Task<IEnumerable<Doctors>> GetAllAsync();
        public Task<Doctors> AddAsync(Doctors doctors);

    }
}
