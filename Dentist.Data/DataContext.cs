
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
        //public DataContext()
        //{
        //    doctor = new List<Doctors> { new Doctors { Name ="Efarim", Id ="123456789" },
        //   new Doctors { Name ="Chana",  Id ="987654321" } };

        //    patients = new List<Patient> { new Patient { Name ="Efarim", Id ="123456789",DateBorn=new DateTime().Date,Age=31,Status=false },
        //   new Patient { Name ="Chana",  Id ="987654321" ,DateBorn=new DateTime().Date,Age=31,Status=false}};

        //    turns = new List<turn> { new turn { Code = 1, IdPatient = "323658036", IdDentist = "320658036", Date = new DateTime(), Hour = new DateTime() } };


        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DentistM");

        }

    }
}
