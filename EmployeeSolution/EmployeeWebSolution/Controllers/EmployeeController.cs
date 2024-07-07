using EmployeeWebSolution.Entities;
using EmployeeWebSolution.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebSolution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpPost]
        public IActionResult Insert(Employee employee)
        {
            employeeService.Insert(employee);
            return Ok();
        }

        [HttpGet]
        public IActionResult Display()
        {
            
            return Ok(employeeService.GetAll());
        }

        [HttpPost("{id}")]
        public IActionResult Delete(int id)
        {
            employeeService.Delete(id);
            return Ok();

        }

        [HttpPut]
        public IActionResult Edit(Employee employee)
        {
            employeeService.Update(employee);
            return Ok();
        }
    }
}
