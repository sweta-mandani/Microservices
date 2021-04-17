using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Microservice.Entities
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public string Department { get; set; }
        public int Marks { get; set; }
    }
}
