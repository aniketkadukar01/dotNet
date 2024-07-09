using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWeb.Models;
using StudentWeb.Services;

namespace StudentWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetStudents() 
        {
            return Ok(_studentService.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Student student)
        {
            _studentService.Insert(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Student student)
        {
            _studentService.Update(student);
            return Ok();
        }

        [HttpGet("sort")]
        public IActionResult Sort()
        {           
            return Ok(_studentService.Sort());
        }

        [HttpPost("search")]
        public IActionResult SearchByStatus(string status)
        {
            return Ok(_studentService.SearchByStatus(status));
        }
    }
}
