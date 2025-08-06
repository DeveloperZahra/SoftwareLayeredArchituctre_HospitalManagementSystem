using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories
{
    // HospitalRepo implements IHospitalRepo interface and handles CRUD operations for Doctor entities
    class HospitalRepo : IHospitalRepo
    {
        private readonly HospitalDbContext _context;   // Readonly instance of the database context used to interact with the database

        // Constructor that receives a HospitalDbContext instance via dependency injection
        public HospitalRepo(HospitalDbContext context)
        {
            _context = context;
        }

        // Adds a new Doctor to the database
        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges(); // Save changes to persist the new doctor
        }

        // Retrieves a list of all doctors from the database
        public List<Doctor> GetDoctors()
        {
            return _context.Doctors.ToList(); // Return all doctors as a list

        }

        // Retrieves a single Doctor based on the provided ID
        public Doctor GetById(int id)
        {
            return _context.Doctors.Find(id);// Find by primary key
        }

        // Updates an existing Doctor's information in the database
        public void Update(Doctor doctor)
        {
            _context.Doctors.Update(doctor);  // Mark entity as modified
            _context.SaveChanges(); // Save changes to apply the update
        }



        public void Delete(int id)
        {
            var abc = GetById(id);
            if (abc != null)
            {
                _context.Doctors.Remove(abc);
                _context.SaveChanges();
            }
        }
    }
}
