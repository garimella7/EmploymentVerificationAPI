
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentVerificationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // This controller class contains methods to handle the https requests for employment verification
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
            if (!ModelState.IsValid)
            {
                return BadRequest(new
                {
                    message = "Validation failed",
                    errors = ModelState.Values.SelectMany(v => v.Errors)
                });
            }

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
