using dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface ITurnServices
    {
        public IEnumerable<turn> getAll();
        public turn get(int id);
        public turn add(turn turn);
        public void delete(int id);
        public void update(int IdPatient, DateTime hour, DateTime date);
    }
}
