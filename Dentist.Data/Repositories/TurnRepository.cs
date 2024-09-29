using Dentist;
using Dentist.Core.Entities;
using Dentist.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dentist.Data.Repositories
{
    public class TurnRepository : ITurnRepository
    {
        private readonly DataContext _context;
        public TurnRepository(DataContext contex)
        {
            _context = contex;
                
        }

        public List<turn> getAll()
        {
            return _context.turns.ToList();
        }
    }
}
