

using Dentist.Core.Entities;
using Dentist.Core.Repositories;
using Dentist.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Service
{
    public class DoctorService: IDoctorService
    {
        private readonly IDoctorRepository _DoctorRepository;
        public DoctorService(IDoctorRepository doctorRepository)
        {
            _DoctorRepository = doctorRepository;
        }

        public List<Doctors> GetList()
        {
            return _DoctorRepository.GetAll();
        }
    }
}
