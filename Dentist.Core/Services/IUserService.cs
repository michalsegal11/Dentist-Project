using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Core.Services
{
    public interface IUserService
    {
        public Task<User> GetByUserNameAsync(string userName, string Password);
        public Task<User> AddUserAsync(User user);
    }
}
