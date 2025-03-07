﻿
using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Repositories
{
    public interface IDoctorRepository
    {
        public IEnumerable<Doctors> GetAll();

        public Doctors Get(string id);

        public Doctors Add(Doctors doctors);
        public Task<IEnumerable<Doctors>> GetAllAsync();


        public Task<Doctors> AddAsync(Doctors doctors);
        public Task UpdateAsync(string id, Doctors doctor);
    }
}
