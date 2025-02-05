using dentist;

namespace Dentist.API.Models
{
    public class PatientPostModel
    {
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }
        public List<turn> turn { get; set; }
    }
}
