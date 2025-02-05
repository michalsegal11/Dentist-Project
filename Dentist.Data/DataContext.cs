
using dentist;
using Dentist;
using Dentist.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace Dentist.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Doctors> doctor { get; set; }
        public DbSet<turn> turns { get; set; }

        public DbSet<Patient> patients { get; set; }

        private readonly IConfiguration _configuration;
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


  
            optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);

        }

    }
}
