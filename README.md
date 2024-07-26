This application is used to verify the employee and return a response.
It is created using ASP.Net core Web API framework.
It contains a POST action method which takes the incoming request and verifies the employee and sends a response.
It also contains a Index file where user can enter the employee details and on submitting the form the javascript code will make a API call and a response is received.

**Steps used to create the application:**
1. Opened Visual studio and created a ASP.Net Core Web API project
2. Created a folder named "Models" and added entity class Employee under subfolder "Entities"
3. Created a EmployeeVerificationRequest class to capture the request object data
4. Created a Api controller class "EmploymentVerification"
5. Created a POST action method "VerifyEmployee" to handle the https POST request for employment verification
6. The action method will verify the employment details and sends a Json response as "Verified" or "Not verified"
7. Created a service class "VerifyEmploymentService" which implements methods from "IVerifyEmploymentService" interface
8. The service class contains method GetEmployees() to get the list of employees which is created using an in-memory datastructure List with sample records 
9. Registered the service class in program.cs file to enable dependency injection
10. Passed the instance of the service class as parameter to api controller constructor
11. Used inbulit Swagger UI to make the API call which sends POST request to the verify employment details and gets the response
12. Created "Index.html" file under wwwroot folder in the application
13. Included UseStaticFiles() and MapFallbackToFile() in program.cs to serve the static files
14. The html form captures the employment details and submits the request
15. Included a JavaScript code which captures the form data and makes the API call to "VerifyEmployee" POST action method
16. Ensured the request is sent to the POST action using action using correct URL
17. The response is then displayed in the UI as "Verified" or "Not verified"
18. Added AddCors() and UseCors() in program.cs file to enable CORS and serve cross origin requests
19. Included UseRouting() in program.cs to enable routing functionality
