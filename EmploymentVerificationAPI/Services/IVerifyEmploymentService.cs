namespace EmploymentVerificationAPI.Services
{
    // It represents the interface for the VerifyEmploymentService.cs class
    public interface IVerifyEmploymentService
    {
        IList<Employee> GetEmployees();
    }
}
