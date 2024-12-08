
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

        public IEnumerable<Patient> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _PatientRepository.GetAll();

        }
        public Patient Get(string id)
        {
            return _PatientRepository.Get(id);
        }

        public Patient Add(Patient patient)
        {
            return _PatientRepository.Add(patient);
        }
    }
}
