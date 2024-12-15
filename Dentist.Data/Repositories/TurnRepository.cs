using dentist;
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
        public IEnumerable<turn> getAll()
        {
            return _context.turns;
        }
        public turn get(int id)
        {
            return _context.turns.FirstOrDefault(t => t.Id == id);
        }
        public turn add(turn turn)
        {
            _context.turns.Add(turn);
            _context.SaveChanges();
            return turn;
        }
        public void delete(int id)
        {
        }
        public void update(int IdPatient,DateTime hour,DateTime date)
        {
            
        }
    }
}
