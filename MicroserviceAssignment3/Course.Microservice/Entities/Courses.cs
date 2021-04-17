using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Microservice.Entities
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int CourseCredits { get; set; }
        public string CourseTrainer { get; set; }
    }
}
