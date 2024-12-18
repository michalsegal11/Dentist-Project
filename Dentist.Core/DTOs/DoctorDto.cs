using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.DTOs
{
    public class DoctorDto
    {
     
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specialization { get; set; }
        public TurnDoctorDto turn { get; set; }
    }
}
