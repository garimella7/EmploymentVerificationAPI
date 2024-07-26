namespace EmploymentVerificationAPI.Models
{
    // This class represents the request object to capture data from incoming https request
    public class EmployeeVerificationRequest
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string VerificationCode { get; set; }
    }
}
