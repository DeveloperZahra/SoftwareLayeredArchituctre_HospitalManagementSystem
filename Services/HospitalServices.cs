using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;
using SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Services
{
    // HospitalServices implements IHospitalServices and provides higher-level business logic for doctor operations
    internal class HospitalServices : IHospitalServices
    {
        // Repository interface used to interact with data storage
        private readonly IHospitalRepo _repo;

        // Constructor that receives a repository via dependency injection
        public HospitalServices(IHospitalRepo repo)
        {
            _repo = repo;

        }

        // Creates a new doctor account and adds it to the repository
        public void CreateAccount(string holdername, string DSpecialty)
        {
            var abc = new Doctor
            {
                HolderName = holdername,
                Specialty = DSpecialty
            };
        }

        public IEnumerable<Doctor> GetAllDoctors()

        {
            return _repo.GetDoctors();
        }







    }
}
