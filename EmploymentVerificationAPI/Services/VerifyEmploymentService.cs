namespace EmploymentVerificationAPI.Services
{
    public class VerifyEmploymentService : IVerifyEmploymentService
    {
        public IList<Employee> GetEmployees()
        {
            var employeeList = new List<Employee>()
            {
                new Employee() { EmployeeID = 1, CompanyName = "TCS", VerificationCode = "T1593469" },
                new Employee() { EmployeeID = 2, CompanyName = "Deloitte", VerificationCode = "D2648984" },
                new Employee() { EmployeeID = 3, CompanyName = "Amazon", VerificationCode = "A4683629" },
                new Employee() { EmployeeID = 4, CompanyName = "Cisive", VerificationCode = "C5612782" },
                new Employee() { EmployeeID = 5, CompanyName = "Google", VerificationCode = "G2392349" },
                new Employee() { EmployeeID = 6, CompanyName = "ISPC", VerificationCode = "I25323783" },
                new Employee() { EmployeeID = 7, CompanyName = "Intel", VerificationCode = "I89234336" }
            };

            return employeeList;
        }
    }
}
