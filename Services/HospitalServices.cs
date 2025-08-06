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
        private readonly IHospitalRepo _repo;

        public HospitalServices(IHospitalRepo repo)
        {
            _repo = repo;

        }

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
