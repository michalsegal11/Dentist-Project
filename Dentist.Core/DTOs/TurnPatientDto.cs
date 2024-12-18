using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.DTOs
{
    public class TurnPatientDto
    {
        public string IdPatient { get; set; }
        public string IdDentist { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
    }
}
