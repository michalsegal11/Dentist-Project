using dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Entities
{
    public class Doctors
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specialization { get; set; }
        public List<turn>turns { get; set; }
        public string Status { get; set; }
    }
}

