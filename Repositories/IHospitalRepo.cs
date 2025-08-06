using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories
{
    // Interface defining contract for Doctor repository operations
    public interface IHospitalRepo
    {
        void Add(Doctor doctor); // Adds a new doctor to the database
        void Delete(int id); // Deletes a doctor from the database using their ID
        Doctor GetById(int id); // Retrieves a doctor by their unique ID
        List<Doctor> GetDoctors();  // Retrieves a list of all doctors from the database
        void Update(Doctor doctor);
    }
}