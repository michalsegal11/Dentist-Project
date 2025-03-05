using dentist;

namespace Dentist.Api.Models
{
    public class DoctorPostModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Specialization { get; set; }
        public bool Status { get; set; }
       
        public string Password { get; set; }



    }
}
