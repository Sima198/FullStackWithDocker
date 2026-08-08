using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        [HttpGet]
        [Route("api/Students")]
        public IActionResult GetStudents()
        {
            var students = new List<Models.Students>
            {
                new Models.Students { RollNo = 1, Name = "John Doe", Qualification = "B.Sc", Percentage = 85 },
                new Models.Students { RollNo = 2, Name = "Jane Smith", Qualification = "M.Sc", Percentage = 90 },
                new Models.Students { RollNo = 3, Name = "Alice Johnson", Qualification = "B.A", Percentage = 78 },
                new Models.Students { RollNo = 4, Name = "Anushka", Qualification = "B.E", Percentage = 89 },
                new Models.Students { RollNo = 5, Name = "Kajal", Qualification = "B.Teach", Percentage = 90 },
                new Models.Students { RollNo = 6, Name = "Richa", Qualification = "B.Com", Percentage = 81 },
                new Models.Students { RollNo = 7, Name = "Maya", Qualification = "B.C.A", Percentage = 70 }

            };
            return Ok(students);
        }
    }
}
