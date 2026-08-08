using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapiwithdockercompose.Models;

namespace webapiwithdockercompose.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class CourseAPIController : ControllerBase
    {
        CiitstudContext _db;

        public CourseAPIController(CiitstudContext db)
        {
            _db = db;

        }

        [HttpGet]
        [Route("api/Courses")]
        public List<TbltrainingCourse> GetCourses()
        {
            return _db.TbltrainingCourses.ToList();
        }

        [HttpGet]
        [Route("api/Course/{id}")]
        public TbltrainingCourse GetCoursebyid(int id)
        {
            return _db.TbltrainingCourses.Find(id);
        }
    }
}
