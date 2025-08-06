using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories
{
    // Interface defining contract for Doctor repository operations
    public interface IHospitalRepo
    {
        void Add(Doctor doctor); // Adds a new doctor to the database
        void Delete(int id); // Deletes a doctor from the database using their ID
        Doctor GetById(int id);
        List<Doctor> GetDoctors();
        void Update(Doctor doctor);
    }
}