
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerificationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentVerificationController : ControllerBase
    {
        private readonly IVerifyEmploymentService _verifyEmploymentService;

        public EmploymentVerificationController(IVerifyEmploymentService verifyEmploymentService)
        {
            this._verifyEmploymentService = verifyEmploymentService;
        }

        [HttpPost("VerifyEmployee")]
        public IActionResult VerifyEmployee([FromBody] EmployeeVerificationRequest employeeVerificationRequest)
        {
            var employee = _verifyEmploymentService.GetEmployees().FirstOrDefault(e =>
                            e.EmployeeID == employeeVerificationRequest.EmployeeId &&
                            e.CompanyName == employeeVerificationRequest.CompanyName &&
                            e.VerificationCode == employeeVerificationRequest.VerificationCode);

            if (employee != null)
            {
                return Ok(new {message = "Employee is verified"});
            }
            else
            {
                return NotFound(new { message = "Employee is not verified" });
            }
        }
    }
}
