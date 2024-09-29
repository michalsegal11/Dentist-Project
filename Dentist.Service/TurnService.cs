using Dentist;
using Dentist.Core.Entities;
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


        public List<turn> getAll()
        {
            return _ITurnRepository.getAll();
        }

    }

}
