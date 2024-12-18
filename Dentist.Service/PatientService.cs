
using Dentist.Core.Repositories;
using Dentist.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Service
{
    public class PatientService: IPatientService
    {
        private readonly IPatientRepository _PatientRepository;
        public PatientService(IPatientRepository patientRepository)
        {
            _PatientRepository = patientRepository;
        }

        public async Task<IEnumerable<Patient>> GetAllAsync()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return await _PatientRepository.GetAllAsync();
        }
        public Patient Get(int id)
        {
            return _PatientRepository.Get(id);
        }

        public Patient Add(Patient patient)
        {
            return _PatientRepository.Add(patient);
        }

        public async Task<Patient> AddAsync(Patient patient)
        {
            return await _PatientRepository.AddAsync(patient);
        }
    }
}
