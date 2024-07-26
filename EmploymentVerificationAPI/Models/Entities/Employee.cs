

namespace EmploymentVerificationAPI.Models.Entities
{
    // This class represents the entity class for Employee
    [Table(name:"Employees")]
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(30)]
        public string VerificationCode { get; set; }
    }
}
