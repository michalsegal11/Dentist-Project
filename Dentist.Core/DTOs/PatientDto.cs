using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.DTOs
{
    public class PatientDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }
        public TurnPatientDto TurnPatientDto { get; set; }
    }
}
