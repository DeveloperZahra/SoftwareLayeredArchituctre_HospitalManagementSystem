using Microsoft.EntityFrameworkCore;
using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem
{
    // Defines the database context for the Hospital Management System,
    // enabling interaction with the database using Entity Framework Core
    internal class HospitalDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; } // Represents the Doctors table in the database

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Configures the database connection settings
        {
            optionsBuilder.UseSqlServer("Data Source=(local); Initial Catalog=HospitalDb; Integrated Security=True; TrustServerCertificate=True");


        }
    }
}
