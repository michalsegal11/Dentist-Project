using dentist;
using Dentist.Core.Repositories;
using Dentist.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dentist.Service
{
    public class TurnService : ITurnServices
    {
        private readonly ITurnRepository _ITurnRepository;

        public TurnService(ITurnRepository iTurnRepository)
        {
            _ITurnRepository = iTurnRepository;
        }


        public IEnumerable<turn> getAll()
        {
            return _ITurnRepository.getAll();
        }
        public turn get(int id)
        {
            return _ITurnRepository.get(id);
        }
        public turn add(turn turn)
        {
            return _ITurnRepository.add(turn);
        }
        public void delete(int id)
        {
            _ITurnRepository.delete(id);
        }
        public void update(int IdPatient, DateTime hour, DateTime date)
        {
            _ITurnRepository.update(IdPatient, hour, date);
        }
    }

}
