using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Services
{
    // Interface defining the service layer contract for managing doctor-related operations
    internal interface IHospitalServices
    {
        void CreateAccount(string holdername, string DSpecialty);  // Creates a new doctor account with the provided name and specialty
        IEnumerable<Doctor> GetAllDoctors();
    }
}