using SoftwareLayeredArchituctre_HospitalManagementSystem.Repositories;
using SoftwareLayeredArchituctre_HospitalManagementSystem.Services;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using HospitalDbContext context = new HospitalDbContext();   // Create a new instance of the database context
            context.Database.EnsureCreated(); // Ensure the database is created (only creates if it doesn't exist)

            // Set up the repository and service layer
            IHospitalRepo hospitalRepo = new HospitalRepo(context); 
            IHospitalServices hospitalServices = new HospitalServices(hospitalRepo);

            // Add sample doctor accounts to the system
            hospitalServices.CreateAccount("Zahra", "CreateAccount");
            hospitalServices.CreateAccount("Sara", "General Practitioner");
            hospitalServices.CreateAccount("Ali", "Psychiatrist");

            foreach (var abc in hospitalServices.GetAllDoctors())
            {

                Console.WriteLine($" {abc.Id} - {abc.HolderName} - {abc.Specialty} ");
            }


            




        }
    }
}
