using dentist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Repositories
{
    public interface ITurnRepository
    {
        public IEnumerable<turn> getAll();
        public turn get(int id);
        public turn add(turn turn);
        public void delete(int id);
        public void update(int IdPatient, DateTime hour, DateTime date);

    }
}
