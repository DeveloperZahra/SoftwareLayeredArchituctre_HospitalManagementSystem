using SoftwareLayeredArchituctre_HospitalManagementSystem.Models;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories
{
    public interface IHospitalRepo
    {
        void Add(Doctor doctor);
        void Delete(int id);
        Doctor GetById(int id);
        List<Doctor> GetDoctors();
        void Update(Doctor doctor);
    }
}