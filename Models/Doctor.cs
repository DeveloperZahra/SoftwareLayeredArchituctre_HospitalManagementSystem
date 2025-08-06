using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLayeredArchituctre_HospitalManagementSystem.Models
{
    // Define the Doctor class to represent a doctor entity in the system
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string HolderName { get; set; }

        public string Specialty { get; set; }

    }
}
