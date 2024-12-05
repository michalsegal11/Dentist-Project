
using Dentist;
using Dentist.Core.Entities;
using Microsoft.EntityFrameworkCore;
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
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DentistM");

        }

    }
}
