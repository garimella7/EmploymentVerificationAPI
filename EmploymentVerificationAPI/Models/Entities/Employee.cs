using System.ComponentModel.DataAnnotations.Schema;

namespace EmploymentVerificationAPI.Models.Entities
{
    [Table(name:"Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
