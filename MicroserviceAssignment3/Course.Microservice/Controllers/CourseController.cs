using Course.Microservice.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Course.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        [HttpGet("getCourse")]
        public ActionResult<IEnumerable<string>> Get()
        {
            Courses courses = GetStaticData();
            return Ok(courses);
        }

        private Courses GetStaticData()
        {
            Courses courses = new Courses()
            {
                Id = 1,
                CourseName = ".NET Core",
                CourseCredits = 30,
                CourseTrainer = "XYZ"
            };

            return courses;
        }
    }
}
