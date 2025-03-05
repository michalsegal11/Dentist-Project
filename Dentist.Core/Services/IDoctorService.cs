

using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface IDoctorService
    {
        public IEnumerable<Doctors> GetList();
      
        public Doctors Add(Doctors doctor);
        public Task<Doctors> Get(string id);

        public Task<IEnumerable<Doctors>> GetAllAsync();
        public Task<Doctors> AddAsync(Doctors doctors);
        public Task UpdateAsync(string id, Doctors doctor);
    }
}
