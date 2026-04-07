using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private static List<Employee> empList = new List<Employee>();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(empList);
    }

    [HttpPost]
    public IActionResult Post(Employee emp)
    {
        empList.Add(emp);
        return Ok("Employee added successfully");
    }
}
