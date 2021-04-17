using Microsoft.AspNetCore.Mvc;
using Student.Microservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Student.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet("getStudent")]
        public ActionResult<IEnumerable<string>> Get()
        {
            Students students = GetStaticData();
            return Ok(students);
        }

      
        private Students GetStaticData()
        {
            Students students = new Students
            {
                Id = 1,
                Name = "XYZ",
                CourseId = 1,
                Department = "IT",
                Marks = 10,
            };

            return students;
        }
    }
}
