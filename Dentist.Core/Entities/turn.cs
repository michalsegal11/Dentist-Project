
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Entities
{
    public class turn
    {

        public string Id { get; set; }
        public string IdPatient { get; set; }
        public string IdDentist { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
    }
}
