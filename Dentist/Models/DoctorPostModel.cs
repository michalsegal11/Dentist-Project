using dentist;

namespace Dentist.Api.Models
{
    public class DoctorPostModel
    {

        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specialization { get; set; }
        public List<turn> turns { get; set; }
        public string Status { get; set; }

    }
}
