using Dentist.Core.Entities;
using Dentist.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Dentist.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<User> GetByUserNameAsync(string userName, string Password)
        {
            return await _dataContext.User.FirstOrDefaultAsync(u => u.UserName == userName && u.Password == Password);
        }

        public async Task<User> AddUserAsync(User user)
        {
            _dataContext.User.Add(user);
            await _dataContext.SaveChangesAsync();
            return user;
        }



        public async Task UpdateAsync(string id, Doctors doctor)
        {

            var Doctor = _dataContext.doctor.FirstOrDefault(x => x.Id == id);
            Doctor.Id = doctor.Id;
            Doctor.Adress = doctor.Adress;
            Doctor.Status = doctor.Status;
            Doctor.Specialization = doctor.Specialization;

            await _dataContext.SaveChangesAsync();


        }
    }
}
