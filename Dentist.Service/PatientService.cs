
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

        public List<Patient> GetList()
        {
            //לוגיקה עיסקית
            //קבלת נתונים מה db
            //לוגיקה עסקית
            return _PatientRepository.GetAll();

        }
    }
}
